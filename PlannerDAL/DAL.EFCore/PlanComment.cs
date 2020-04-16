using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class PlanComment
    {
        public long PlanCommentId { get; set; }
        public long PlanId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime DateTime { get; set; }
        public byte[] Comment { get; set; }
        public string TextComment { get; set; }

        public virtual Plans Plan { get; set; }
    }
}
