using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignGraph
    {
        public DesignGraph()
        {
            DesignGraphNode = new HashSet<DesignGraphNode>();
            DesignGraphNodeConnection = new HashSet<DesignGraphNodeConnection>();
        }

        public long DesignGraphId { get; set; }
        public string DesignGraphName { get; set; }
        public long? MasterDataViewId { get; set; }
        public long? PlanId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual ICollection<DesignGraphNode> DesignGraphNode { get; set; }
        public virtual ICollection<DesignGraphNodeConnection> DesignGraphNodeConnection { get; set; }
    }
}
