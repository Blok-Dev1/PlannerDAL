using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class TaskBackup
    {
        public long TaskId { get; set; }
        public long ScheduleId { get; set; }
        public long PlanId { get; set; }
        public long? PlanElementId { get; set; }
        public long TaskTypeId { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public string Rate { get; set; }
        public string RateAbbr { get; set; }
        public decimal? Duration { get; set; }
        public string DurationAbbr { get; set; }
        public double? Distance { get; set; }
        public string DistanceAbbr { get; set; }
        public double? FloorArea { get; set; }
        public string FloorAreaAbbr { get; set; }
        public double? Weight { get; set; }
        public string WeightAbbr { get; set; }
        public double? Volume { get; set; }
        public string VolumeAbbr { get; set; }
        public double? StartPointX { get; set; }
        public double? StartPointY { get; set; }
        public double? StartPointZ { get; set; }
        public double? EndPointX { get; set; }
        public double? EndPointY { get; set; }
        public double? EndPointZ { get; set; }
        public double? StartDistance { get; set; }
        public double? EndDistance { get; set; }
        public int? SequenceOrder { get; set; }
        public int? LevelNumber { get; set; }
        public int? EntityOrder { get; set; }
        public long? InternalToTaskId { get; set; }
        public double? InternalToTaskDelay { get; set; }
        public string InternalToTaskDelayAbbr { get; set; }
        public string Epsid { get; set; }
        public string Resources { get; set; }
        public string ResourcesLong { get; set; }
        public bool ReverseDirection { get; set; }
        public bool BreakInternalFrom { get; set; }
        public bool BreakInternalTo { get; set; }
        public bool IsTunnel { get; set; }
        public decimal? TunnelWallWidth { get; set; }
        public long? TaskScheduleTypeId { get; set; }
        public string ActivityCode { get; set; }
        public long? LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid TaskGuid { get; set; }
        public bool? InExecution { get; set; }
        public double? CompletionPercentage { get; set; }
        public string DrivingProperty { get; set; }
        public string DrivingPropertyUnit { get; set; }
        public string Fxsname { get; set; }
        public string TaskFieldValuesCsv { get; set; }
        public byte[] TaskFieldValuesBin { get; set; }
    }
}
