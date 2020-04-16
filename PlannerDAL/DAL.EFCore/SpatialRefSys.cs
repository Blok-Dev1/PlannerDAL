using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class SpatialRefSys
    {
        public int Srid { get; set; }
        public string AuthName { get; set; }
        public int? AuthSrid { get; set; }
        public string Srtext { get; set; }
    }
}
