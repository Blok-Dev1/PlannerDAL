using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignStandardEntity
    {
        public long DesignStandardEntityId { get; set; }
        public long DesignStandardToolId { get; set; }
        public string DesignType { get; set; }
        public string SubType { get; set; }
        public int CadentityId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string Rate { get; set; }
        public string RateUnit { get; set; }
        public long? TaskScheduleTypeId { get; set; }
        public string ActivityCode { get; set; }

        public virtual ActivityCode ActivityCodeNavigation { get; set; }
        public virtual DesignStandardTool DesignStandardTool { get; set; }
        public virtual TaskScheduleType TaskScheduleType { get; set; }
    }
}
