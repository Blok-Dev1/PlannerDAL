using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceAssignment = new HashSet<ResourceAssignment>();
        }

        public long ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CodeOrExternalId { get; set; }
        public string ExternalSource { get; set; }
        public double? DefaultProductionRate { get; set; }
        public string DefaultProductionRateAbr { get; set; }
        public string Type { get; set; }
        public double? MaxUnits { get; set; }
        public int? MaxConcurrentTasks { get; set; }
        public bool? IsHaulage { get; set; }
        public bool? IsReplaceable { get; set; }
        public string Notes { get; set; }
        public long ScheduleId { get; set; }
        public long PlanId { get; set; }
        public string Epsid { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<ResourceAssignment> ResourceAssignment { get; set; }
    }
}
