using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Eavmapping
    {
        public long EavmappingId { get; set; }
        public string DesignAttribute { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
