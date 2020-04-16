using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Waste
    {
        public long WasteId { get; set; }
        public string Name { get; set; }
        public double? Density { get; set; }
    }
}
