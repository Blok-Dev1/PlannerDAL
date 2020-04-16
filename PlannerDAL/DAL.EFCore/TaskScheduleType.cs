using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskScheduleType
    {
        public TaskScheduleType()
        {
            DesignStandardEntity = new HashSet<DesignStandardEntity>();
            Task = new HashSet<Task>();
        }

        public long TaskScheduleTypeId { get; set; }
        public string TaskScheduleType1 { get; set; }
        public string TaskTypeDescription { get; set; }

        public virtual ICollection<DesignStandardEntity> DesignStandardEntity { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
