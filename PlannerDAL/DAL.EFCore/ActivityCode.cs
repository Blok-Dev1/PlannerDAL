using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class ActivityCode
    {
        public ActivityCode()
        {
            DesignStandardEntity = new HashSet<DesignStandardEntity>();
            Task = new HashSet<Task>();
        }

        public string ActivityCode1 { get; set; }
        public string Description { get; set; }
        public string ExternalId { get; set; }

        public virtual ICollection<DesignStandardEntity> DesignStandardEntity { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
