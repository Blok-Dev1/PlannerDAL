using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraphNodeType
    {
        public DesignGraphNodeType()
        {
            DesignGraphNode = new HashSet<DesignGraphNode>();
        }

        public int DesignGraphNodeTypeId { get; set; }
        public string DesignGraphNodeTypeName { get; set; }

        public virtual ICollection<DesignGraphNode> DesignGraphNode { get; set; }
    }
}
