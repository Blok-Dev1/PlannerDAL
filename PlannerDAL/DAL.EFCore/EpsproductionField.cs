using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class EpsproductionField
    {
        public long EpsfieldId { get; set; }
        public string Abbreviation { get; set; }
        public int Decimals { get; set; }
        public bool TrackActual { get; set; }
        public int WeightedBy { get; set; }
        public string NumberFormat { get; set; }
        public int? PeriodCount { get; set; }
        public string TargetPeriod { get; set; }
        public bool? CostField { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Epsmapping Epsfield { get; set; }
    }
}
