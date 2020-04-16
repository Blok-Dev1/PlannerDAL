using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class LicenseLog
    {
        public DateTime LogDate { get; set; }
        public string DatabaseUserName { get; set; }
        public string WindowsUserName { get; set; }
        public string ComputerName { get; set; }
        public string ProductName { get; set; }
        public string ModuleName { get; set; }
    }
}
