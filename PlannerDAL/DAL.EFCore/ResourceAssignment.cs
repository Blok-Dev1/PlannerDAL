using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class ResourceAssignment
    {
        public long ResourceAssignmentId { get; set; }
        public long TaskId { get; set; }
        public long ResourceId { get; set; }
        public double NumberOfUnits { get; set; }
        public double? ProductionRate { get; set; }
        public string ProductionRateUnit { get; set; }
        public string AssignmentType { get; set; }
        public string Operation { get; set; }
        public bool FromProductionRateTable { get; set; }
        public double? StartDistance { get; set; }
        public double? EndDistance { get; set; }
        public string Epsid { get; set; }

        public virtual Resource Resource { get; set; }
        public virtual Task Task { get; set; }
    }
}
