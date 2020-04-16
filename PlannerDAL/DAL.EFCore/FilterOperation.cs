using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class FilterOperation
    {
        public FilterOperation()
        {
            LegendFilter = new HashSet<LegendFilter>();
        }

        public int FilterOperationId { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<LegendFilter> LegendFilter { get; set; }
    }
}
