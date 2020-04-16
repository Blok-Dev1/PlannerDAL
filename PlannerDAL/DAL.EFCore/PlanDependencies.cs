using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class PlanDependencies
    {
        public long DependencyId { get; set; }
        public long DependencyTypeId { get; set; }
        public long? FromTaskId { get; set; }
        public long? ToTaskId { get; set; }
        public double Delay { get; set; }
        public string DelayAbbr { get; set; }
        public long PlanId { get; set; }
    }
}
