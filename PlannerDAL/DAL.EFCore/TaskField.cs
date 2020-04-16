using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskField
    {
        public TaskField()
        {
            TaskFieldProperty = new HashSet<TaskFieldProperty>();
        }

        public long TaskFieldId { get; set; }
        public int TaskFieldType { get; set; }
        public string TaskFieldName { get; set; }
        public long? ScheduleId { get; set; }
        public long? EpsfieldGroupId { get; set; }

        public virtual EpsfieldGroup EpsfieldGroup { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<TaskFieldProperty> TaskFieldProperty { get; set; }
    }
}
