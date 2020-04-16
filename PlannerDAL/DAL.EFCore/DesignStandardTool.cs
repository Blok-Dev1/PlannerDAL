using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignStandardTool
    {
        public DesignStandardTool()
        {
            DesignStandardEntity = new HashSet<DesignStandardEntity>();
            DesignStandardToolParameter = new HashSet<DesignStandardToolParameter>();
        }

        public long DesignStandardToolId { get; set; }
        public long? DesignStandardLibraryId { get; set; }
        public string ToolTypeFullName { get; set; }
        public string CategoryPath { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DesignStandardLibrary DesignStandardLibrary { get; set; }
        public virtual ICollection<DesignStandardEntity> DesignStandardEntity { get; set; }
        public virtual ICollection<DesignStandardToolParameter> DesignStandardToolParameter { get; set; }
    }
}
