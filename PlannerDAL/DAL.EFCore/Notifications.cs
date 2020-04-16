using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Notifications
    {
        public long Id { get; set; }
        public string Event { get; set; }
        public string Url { get; set; }
        public string Parameters { get; set; }
        public string Description { get; set; }
    }
}
