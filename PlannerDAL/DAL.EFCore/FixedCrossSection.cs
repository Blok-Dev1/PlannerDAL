using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class FixedCrossSection
    {
        public long FixedCrossSectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShapeType { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double? Area { get; set; }
        public string SerializedObject { get; set; }
        public string SerializedObjectType { get; set; }
        public byte[] ShapeData { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
