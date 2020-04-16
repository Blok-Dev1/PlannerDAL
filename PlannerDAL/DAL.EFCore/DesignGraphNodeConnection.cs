using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraphNodeConnection
    {
        public long DesignGraphNodeConnectionId { get; set; }
        public long FromDesignGraphNodeId { get; set; }
        public long ToDesignGraphNodeId { get; set; }
        public string Parameter { get; set; }
        public string ParameterDisplay { get; set; }
        public long? DesignGraphNodeParameterId { get; set; }
        public long DesignGraphId { get; set; }
        public bool FeedConnection { get; set; }
        public string FeedObjectIndexes { get; set; }

        public virtual DesignGraph DesignGraph { get; set; }
        public virtual DesignGraphNodeParameter DesignGraphNodeParameter { get; set; }
        public virtual DesignGraphNode FromDesignGraphNode { get; set; }
        public virtual DesignGraphNode ToDesignGraphNode { get; set; }
    }
}
