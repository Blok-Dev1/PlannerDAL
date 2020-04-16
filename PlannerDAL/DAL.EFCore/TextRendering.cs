using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TextRendering
    {
        public TextRendering()
        {
            AttributeRendering = new HashSet<AttributeRendering>();
        }

        public long TextRenderingId { get; set; }
        public string TypeFace { get; set; }
        public string FontWeight { get; set; }
        public string FontStyle { get; set; }
        public double? Size { get; set; }
        public double? OffSet { get; set; }
        public double? Angle { get; set; }
        public double? Direction { get; set; }
        public double? Normal { get; set; }
        public string Position { get; set; }
        public long? PlanId { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual ICollection<AttributeRendering> AttributeRendering { get; set; }
    }
}
