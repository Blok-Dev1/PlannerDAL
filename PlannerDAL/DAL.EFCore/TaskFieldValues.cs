using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskFieldValues
    {
        public long TaskFieldValueId { get; set; }
        public string TaskFieldValue { get; set; }
        public long TaskFieldId { get; set; }
        public long TaskId { get; set; }
    }
}
