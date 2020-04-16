using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DependencyType
    {
        public DependencyType()
        {
            CustomDependency = new HashSet<CustomDependency>();
            Dependency = new HashSet<Dependency>();
        }

        public long DependencyTypeId { get; set; }
        public string DependencyType1 { get; set; }
        public string DependencyTypeDescription { get; set; }

        public virtual ICollection<CustomDependency> CustomDependency { get; set; }
        public virtual ICollection<Dependency> Dependency { get; set; }
    }
}
