using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class CalendarTemplate
    {
        public long TemplateId { get; set; }
        public long CalendarId { get; set; }
        public string Label { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PeriodNumber { get; set; }

        public virtual ReportingCalendars Calendar { get; set; }
    }
}
