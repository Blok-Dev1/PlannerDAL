using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskType
    {
        public TaskType()
        {
            Task = new HashSet<Task>();
        }

        public long TaskTypeId { get; set; }
        public string TaskType1 { get; set; }
        public string TaskTypeDescription { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
