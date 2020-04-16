using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskFieldProperty
    {
        public long TaskFieldPropertyId { get; set; }
        public string TaskFieldPropertyName { get; set; }
        public string TaskFieldPropertyValue { get; set; }
        public long TaskFieldId { get; set; }

        public virtual TaskField TaskField { get; set; }
    }
}
