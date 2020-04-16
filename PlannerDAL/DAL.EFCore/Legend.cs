using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Legend
    {
        public Legend()
        {
            LegendItem = new HashSet<LegendItem>();
        }

        public long LegendId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public long? PlanId { get; set; }
        public long? ScheduleId { get; set; }
        public bool? Active { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<LegendItem> LegendItem { get; set; }
    }
}
