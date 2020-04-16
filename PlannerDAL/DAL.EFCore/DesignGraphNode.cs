using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraphNode
    {
        public DesignGraphNode()
        {
            DesignGraphNodeConnectionFromDesignGraphNode = new HashSet<DesignGraphNodeConnection>();
            DesignGraphNodeConnectionToDesignGraphNode = new HashSet<DesignGraphNodeConnection>();
            DesignGraphNodeElements = new HashSet<DesignGraphNodeElements>();
            DesignGraphNodeParameter = new HashSet<DesignGraphNodeParameter>();
            InverseGroupingParent = new HashSet<DesignGraphNode>();
        }

        public long DesignGraphNodeId { get; set; }
        public string DesignGraphNodeName { get; set; }
        public long? GroupingParentId { get; set; }
        public int? DesignGraphNodeTypeId { get; set; }
        public bool? RegenerateGraphOnChange { get; set; }
        public long DesignGraphId { get; set; }
        public string NodePath { get; set; }

        public virtual DesignGraph DesignGraph { get; set; }
        public virtual DesignGraphNodeType DesignGraphNodeType { get; set; }
        public virtual DesignGraphNode GroupingParent { get; set; }
        public virtual ICollection<DesignGraphNodeConnection> DesignGraphNodeConnectionFromDesignGraphNode { get; set; }
        public virtual ICollection<DesignGraphNodeConnection> DesignGraphNodeConnectionToDesignGraphNode { get; set; }
        public virtual ICollection<DesignGraphNodeElements> DesignGraphNodeElements { get; set; }
        public virtual ICollection<DesignGraphNodeParameter> DesignGraphNodeParameter { get; set; }
        public virtual ICollection<DesignGraphNode> InverseGroupingParent { get; set; }
    }
}
