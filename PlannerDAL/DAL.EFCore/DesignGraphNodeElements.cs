using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraphNodeElements
    {
        public long DesignGraphNodeElementId { get; set; }
        public long DesignGraphNodeId { get; set; }
        public long PlanElementId { get; set; }
        public bool IsSolid { get; set; }

        public virtual DesignGraphNode DesignGraphNode { get; set; }
        public virtual PlanElements PlanElement { get; set; }
    }
}
