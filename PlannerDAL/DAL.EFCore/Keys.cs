using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Keys
    {
        public string Product { get; set; }
        public byte[] Key { get; set; }
    }
}
