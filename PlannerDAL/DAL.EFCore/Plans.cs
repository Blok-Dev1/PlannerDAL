using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Plans
    {
        public Plans()
        {
            Dependency = new HashSet<Dependency>();
            DesignGraph = new HashSet<DesignGraph>();
            InverseCopiedFromPlan = new HashSet<Plans>();
            Legend = new HashSet<Legend>();
            PlanComment = new HashSet<PlanComment>();
            PlanElements = new HashSet<PlanElements>();
            ReportingCalendars = new HashSet<ReportingCalendars>();
            Resource = new HashSet<Resource>();
            Schedule = new HashSet<Schedule>();
            Task = new HashSet<Task>();
            TextRendering = new HashSet<TextRendering>();
            XdataAttribute = new HashSet<XdataAttribute>();
        }

        public long PlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public string CreatorCaduserId { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsPublic { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsLocked { get; set; }
        public string Status { get; set; }
        public long? CopiedFromPlanId { get; set; }

        public virtual Plans CopiedFromPlan { get; set; }
        public virtual ICollection<Dependency> Dependency { get; set; }
        public virtual ICollection<DesignGraph> DesignGraph { get; set; }
        public virtual ICollection<Plans> InverseCopiedFromPlan { get; set; }
        public virtual ICollection<Legend> Legend { get; set; }
        public virtual ICollection<PlanComment> PlanComment { get; set; }
        public virtual ICollection<PlanElements> PlanElements { get; set; }
        public virtual ICollection<ReportingCalendars> ReportingCalendars { get; set; }
        public virtual ICollection<Resource> Resource { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<TextRendering> TextRendering { get; set; }
        public virtual ICollection<XdataAttribute> XdataAttribute { get; set; }
    }
}
