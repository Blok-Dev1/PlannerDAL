using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class ReportingCalendars
    {
        public ReportingCalendars()
        {
            CalendarTemplate = new HashSet<CalendarTemplate>();
        }

        public long CalendarId { get; set; }
        public long ScheduleId { get; set; }
        public long PlanId { get; set; }
        public string Name { get; set; }
        public bool IsLocked { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<CalendarTemplate> CalendarTemplate { get; set; }
    }
}
