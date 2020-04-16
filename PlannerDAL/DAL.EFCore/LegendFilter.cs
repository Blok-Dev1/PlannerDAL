using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class LegendFilter
    {
        public long LegendFilterId { get; set; }
        public long LegendGroupId { get; set; }
        public int Category { get; set; }
        public string TypeFullName { get; set; }
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string FieldValue1 { get; set; }
        public string FieldValue2 { get; set; }
        public int? OperationId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual FilterCategory CategoryNavigation { get; set; }
        public virtual LegendGroup LegendGroup { get; set; }
        public virtual FilterOperation Operation { get; set; }
    }
}
