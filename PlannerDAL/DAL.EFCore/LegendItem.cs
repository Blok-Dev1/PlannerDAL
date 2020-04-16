using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class LegendItem
    {
        public LegendItem()
        {
            LegendGroup = new HashSet<LegendGroup>();
        }

        public long LegendItemId { get; set; }
        public long LegendId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte ColorRed { get; set; }
        public byte ColorGreen { get; set; }
        public byte ColorBlue { get; set; }
        public byte ColorAlpha { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Legend Legend { get; set; }
        public virtual ICollection<LegendGroup> LegendGroup { get; set; }
    }
}
