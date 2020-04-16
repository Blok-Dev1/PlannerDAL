using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignStandardLibrary
    {
        public DesignStandardLibrary()
        {
            DesignStandardTool = new HashSet<DesignStandardTool>();
            Epstemplate = new HashSet<Epstemplate>();
        }

        public long DesignStandardLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public int? CadlibraryId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<DesignStandardTool> DesignStandardTool { get; set; }
        public virtual ICollection<Epstemplate> Epstemplate { get; set; }
    }
}
