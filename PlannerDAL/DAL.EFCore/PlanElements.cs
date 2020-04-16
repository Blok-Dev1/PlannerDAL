using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class PlanElements
    {
        public PlanElements()
        {
            DependencyFromPlanElement = new HashSet<Dependency>();
            DependencyToPlanElement = new HashSet<Dependency>();
            DesignGraphNodeElements = new HashSet<DesignGraphNodeElements>();
            InverseLinkedCenterlinePlanElement = new HashSet<PlanElements>();
            InverseLinkedPlanElement = new HashSet<PlanElements>();
            Task = new HashSet<Task>();
            XdataAttribute = new HashSet<XdataAttribute>();
        }

        public long PlanElementId { get; set; }
        public int CadelementId { get; set; }
        public int CadlibraryId { get; set; }
        public int CadentityId { get; set; }
        public long PlanId { get; set; }
        public long? LinkedPlanElementId { get; set; }
        public bool? IsSolid { get; set; }
        public bool? IsOutline { get; set; }
        public long? LinkedCenterlinePlanElementId { get; set; }
        public double? CenterlineStartPointX { get; set; }
        public double? CenterlineStartPointY { get; set; }
        public double? CenterlineStartPointZ { get; set; }
        public double? CenterlineEndPointX { get; set; }
        public double? CenterlineEndPointY { get; set; }
        public double? CenterlineEndPointZ { get; set; }
        public string XdataAttributesCsv { get; set; }

        public virtual PlanElements LinkedCenterlinePlanElement { get; set; }
        public virtual PlanElements LinkedPlanElement { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual ICollection<Dependency> DependencyFromPlanElement { get; set; }
        public virtual ICollection<Dependency> DependencyToPlanElement { get; set; }
        public virtual ICollection<DesignGraphNodeElements> DesignGraphNodeElements { get; set; }
        public virtual ICollection<PlanElements> InverseLinkedCenterlinePlanElement { get; set; }
        public virtual ICollection<PlanElements> InverseLinkedPlanElement { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<XdataAttribute> XdataAttribute { get; set; }
    }
}
