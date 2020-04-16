using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class CustomDependency
    {
        public long CustomDependencyId { get; set; }
        public long FromTaskId { get; set; }
        public long ToTaskId { get; set; }
        public long ScheduleId { get; set; }
        public double Delay { get; set; }
        public string DelayAbbr { get; set; }
        public long DependencyTypeId { get; set; }

        public virtual DependencyType DependencyType { get; set; }
        public virtual Task FromTask { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual Task ToTask { get; set; }
    }
}
