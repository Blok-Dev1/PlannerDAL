using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class AttributeRendering
    {
        public long AttributeRenderingId { get; set; }
        public string GroupName { get; set; }
        public string AttributeName { get; set; }
        public long TextRenderingId { get; set; }

        public virtual TextRendering TextRendering { get; set; }
    }
}
