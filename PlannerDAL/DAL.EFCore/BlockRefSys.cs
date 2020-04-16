using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class BlockRefSys
    {
        public int Brid { get; set; }
        public string Description { get; set; }
        public int? Srid { get; set; }
        public bool? IsSourceBr { get; set; }
        public bool? IsLocalizedBr { get; set; }
        public bool? IsDestinationBr { get; set; }
        public double? ParentCellSizeX { get; set; }
        public double? ParentCellSizeY { get; set; }
        public double? ParentCellSizeZ { get; set; }
        public double? SubCellSizeX { get; set; }
        public double? SubCellSizeY { get; set; }
        public double? SubCellSizeZ { get; set; }
        public int? ParentCellCountX { get; set; }
        public int? ParentCellCountY { get; set; }
        public int? ParentCellCountZ { get; set; }
        public int? IsIjkRecalculated { get; set; }
        public double? OriginX { get; set; }
        public double? OriginY { get; set; }
        public double? OriginZ { get; set; }
        public double? DisplacementX { get; set; }
        public double? DisplacementY { get; set; }
        public double? DisplacementZ { get; set; }
        public int? RotationAxis1 { get; set; }
        public int? RotationAxis2 { get; set; }
        public int? RotationAxis3 { get; set; }
        public double? RotationAngle1Degrees { get; set; }
        public double? RotationAngle2Degrees { get; set; }
        public double? RotationAngle3Degrees { get; set; }
        public int? SourceBrid { get; set; }
    }
}
