using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class EpsfieldGroup
    {
        public EpsfieldGroup()
        {
            TaskField = new HashSet<TaskField>();
        }

        public long EpsfieldGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<TaskField> TaskField { get; set; }
    }
}
