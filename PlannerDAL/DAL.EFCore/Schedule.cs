using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Schedule
    {
        public Schedule()
        {
            Baseline = new HashSet<Baseline>();
            CustomDependency = new HashSet<CustomDependency>();
            Epsfile = new HashSet<Epsfile>();
            InverseCopiedFromSchedule = new HashSet<Schedule>();
            Legend = new HashSet<Legend>();
            ReportingCalendars = new HashSet<ReportingCalendars>();
            Resource = new HashSet<Resource>();
            Task = new HashSet<Task>();
            TaskField = new HashSet<TaskField>();
        }

        public long ScheduleId { get; set; }
        public long PlanId { get; set; }
        public string Name { get; set; }
        public long? EpstemplateId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool? Active { get; set; }
        public bool? NoEpsTemplate { get; set; }
        public long? CopiedFromScheduleId { get; set; }

        public virtual Schedule CopiedFromSchedule { get; set; }
        public virtual Epstemplate Epstemplate { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual ICollection<Baseline> Baseline { get; set; }
        public virtual ICollection<CustomDependency> CustomDependency { get; set; }
        public virtual ICollection<Epsfile> Epsfile { get; set; }
        public virtual ICollection<Schedule> InverseCopiedFromSchedule { get; set; }
        public virtual ICollection<Legend> Legend { get; set; }
        public virtual ICollection<ReportingCalendars> ReportingCalendars { get; set; }
        public virtual ICollection<Resource> Resource { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<TaskField> TaskField { get; set; }
    }
}
