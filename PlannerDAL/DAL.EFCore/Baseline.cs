using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Baseline
    {
        public long BaselineId { get; set; }
        public long ScheduleId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Filename { get; set; }
        public byte[] File { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
