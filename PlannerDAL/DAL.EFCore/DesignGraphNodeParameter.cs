using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraphNodeParameter
    {
        public DesignGraphNodeParameter()
        {
            DesignGraphNodeConnection = new HashSet<DesignGraphNodeConnection>();
        }

        public long DesignGraphNodeParameterId { get; set; }
        public string DesignGraphNodeParameterName { get; set; }
        public string DesignGraphNodeProperty { get; set; }
        public byte[] DesignGraphNodeValue { get; set; }
        public long DesignGraphNodeId { get; set; }

        public virtual DesignGraphNode DesignGraphNode { get; set; }
        public virtual ICollection<DesignGraphNodeConnection> DesignGraphNodeConnection { get; set; }
    }
}
