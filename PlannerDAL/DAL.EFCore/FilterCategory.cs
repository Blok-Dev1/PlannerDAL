using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class FilterCategory
    {
        public FilterCategory()
        {
            LegendFilter = new HashSet<LegendFilter>();
        }

        public int FilterCategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LegendFilter> LegendFilter { get; set; }
    }
}
