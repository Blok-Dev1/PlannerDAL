using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Epsfile
    {
        public long EpsfileId { get; set; }
        public string Epsname { get; set; }
        public string Epsextension { get; set; }
        public byte[] Epsdata { get; set; }
        public byte[] Exfdata { get; set; }
        public long? ScheduleId { get; set; }
        public long? EpstemplateId { get; set; }
        public bool PrimarySchedule { get; set; }
        public string FileHash { get; set; }

        public virtual Epstemplate Epstemplate { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
