using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Dependency
    {
        public long DependencyId { get; set; }
        public long FromPlanElementId { get; set; }
        public long ToPlanElementId { get; set; }
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        public long DependencyTypeId { get; set; }
        public bool IsInternal { get; set; }
        public bool IsManual { get; set; }
        public long? DependencyRuleId { get; set; }
        public bool SplitDirectionOnTo { get; set; }
        public double FromPointX { get; set; }
        public double FromPointY { get; set; }
        public double FromPointZ { get; set; }
        public double ToPointX { get; set; }
        public double ToPointY { get; set; }
        public double ToPointZ { get; set; }
        public double VectorX { get; set; }
        public double VectorY { get; set; }
        public double VectorZ { get; set; }
        public long PlanId { get; set; }
        public long? FromTaskId { get; set; }
        public long? ToTaskId { get; set; }
        public long? ToSplitTaskId { get; set; }
        public long? ToSecondaryTaskId { get; set; }
        public bool BreakInternalDependency { get; set; }
        public double Delay { get; set; }
        public string DelayAbbr { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual DependencyType DependencyType { get; set; }
        public virtual PlanElements FromPlanElement { get; set; }
        public virtual Task FromTask { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual PlanElements ToPlanElement { get; set; }
        public virtual Task ToSecondaryTask { get; set; }
        public virtual Task ToSplitTask { get; set; }
        public virtual Task ToTask { get; set; }
    }
}
