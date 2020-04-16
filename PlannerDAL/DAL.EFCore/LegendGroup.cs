using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class LegendGroup
    {
        public LegendGroup()
        {
            InverseParentGroup = new HashSet<LegendGroup>();
            LegendFilter = new HashSet<LegendFilter>();
        }

        public long LegendGroupId { get; set; }
        public long LegendItemId { get; set; }
        public string Operation { get; set; }
        public long? ParentGroupId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual LegendItem LegendItem { get; set; }
        public virtual LegendGroup ParentGroup { get; set; }
        public virtual ICollection<LegendGroup> InverseParentGroup { get; set; }
        public virtual ICollection<LegendFilter> LegendFilter { get; set; }
    }
}
