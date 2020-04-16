using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Epstemplate
    {
        public Epstemplate()
        {
            Epsfile = new HashSet<Epsfile>();
            Epsmapping = new HashSet<Epsmapping>();
            Schedule = new HashSet<Schedule>();
        }

        public long EsptemplateId { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public long DesignStandardLibrary { get; set; }
        public string FileExtension { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DesignStandardLibrary DesignStandardLibraryNavigation { get; set; }
        public virtual ICollection<Epsfile> Epsfile { get; set; }
        public virtual ICollection<Epsmapping> Epsmapping { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
