using System;
using DAL.EFCore;
using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Testing
{
    [TestClass]
    public class TestPlans
    {
        [TestMethod]
        public void TestLoadTop5PlansIncludePlanElements()
        {
            using (var uow = new UnitOfWork<PlanDBContext>(new PlanDBContext()))
            {
                var repo = uow.GetRepository<Plans>();

                var plans = repo.GetList(top: 5, orderBy:  t => t.OrderByDescending(p => p.PlanId),
                    include: t => t.Include( p => p.PlanElements), disableTracking: true)
                    .ToList(); // run sql query

                Assert.AreEqual(5L, plans.Count());
            }
        }

        [TestMethod]
        public void TEstLoadFirstPlanAndSaveAsNew()
        {
            using (var uow = new UnitOfWork<PlanDBContext>(new PlanDBContext()))
            {
                var sw = new Stopwatch();

                sw.Start();

                var repo = uow.GetRepository<Plans>();

                var plans = repo.GetList(top: 1, orderBy: t => t.OrderByDescending(p => p.PlanId),
                    disableTracking: true)
                    .ToList(); // run sql query

                var plan = plans.FirstOrDefault();

                var tp = uow.GetRepository<Task>();

                var tasks = tp.GetList(predicate: t => t.PlanId == plan.PlanId, disableTracking: true)
                    .ToList(); // exec qry

                sw.Stop();
                var seconds = sw.ElapsedMilliseconds / 1000d;
                Debug.WriteLine($"Plan({plan.PlanId}) + Tasks ({tasks.Count}) loaded {seconds}s");
                sw.Start();

                plan.PlanId = 0;

                repo.Add(plan);

                // save plan
                uow.SaveChanges();

                tasks.ForEach(t => t.PlanId = plan.PlanId);

                tasks.ForEach(t => t.TaskId = 0);


                // bulk insert
                // tp.BulkAdd(tasks);

                tp.Add(tasks);

                // insert tasks
                uow.SaveChanges();

                sw.Stop();
                seconds = sw.ElapsedMilliseconds / 1000d;
                Debug.WriteLine($"Plan({plan.PlanId}) + Tasks ({tasks.Count}) saved {seconds}s");

                // clean up
                uow.Context.Task.RemoveRange(tasks);

                uow.SaveChanges();

                uow.Context.Plans.Remove(plan);

                uow.SaveChanges();
            }
        }

        [TestMethod]
        public void TestLoadEPSFile()
        {
            using (var uow = new UnitOfWork<PlanDBContext>(new PlanDBContext()))
            {
                var epsrepo = uow.GetRepository<Epsfile>();

                var epsfile = epsrepo.GetList(predicate: t => t.Exfdata != null,
                    orderBy: t => t.OrderByDescending(p => p.EpsfileId),
                    top: 1,
                  disableTracking: true)
                    .FirstOrDefault();
            }
        }

        private PlanDBContext SqlLiteInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<PlanDBContext>()
                .UseSqlite("DataSource=:memory:")
                .Options;

            var context = new PlanDBContext(options);

            context.Database.OpenConnection();
            context.Database.EnsureCreated();
            
            context.SaveChanges();
            return context;
        }

        private PlanDBContext SqlLiteLocalContext()
        {
            var options = new DbContextOptionsBuilder<PlanDBContext>()
                .UseSqlite("DataSource=./mydb.db")
                .Options;

            var context = new PlanDBContext(options);

            context.Database.OpenConnection();
            context.Database.EnsureCreated();

            context.SaveChanges();
            return context;
        }
    }
}
