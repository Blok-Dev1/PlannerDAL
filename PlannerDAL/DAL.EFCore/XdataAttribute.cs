using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class XdataAttribute
    {
        public long XdataAttributeId { get; set; }
        public long PlanElementId { get; set; }
        public long? PlanId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual PlanElements PlanElement { get; set; }
    }
}
