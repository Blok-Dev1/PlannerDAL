using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class DesignStandardToolParameter
    {
        public long DesignStandardToolParameterId { get; set; }
        public long DesignStandardToolId { get; set; }
        public string ParameterName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public string DefaultValue { get; set; }
        public string DefaultValueType { get; set; }
        public string GroupName { get; set; }
        public bool IsEditable { get; set; }
        public bool IsVisible { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DesignStandardTool DesignStandardTool { get; set; }
    }
}
