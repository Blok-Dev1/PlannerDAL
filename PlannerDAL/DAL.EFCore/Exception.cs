using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Exception
    {
        public long ExceptionId { get; set; }
        public string FileName { get; set; }
        public string Cadusername { get; set; }
        public string WindowsUsername { get; set; }
        public string MachineName { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string InnerExceptions { get; set; }
        public DateTime? DateTime { get; set; }
        public string VersionNumber { get; set; }
        public bool? ServerException { get; set; }
    }
}
