using System;
using System.Collections.Generic;

namespace DAL.EFCore
{
    public partial class Epsmapping
    {
        public long EpsfieldId { get; set; }
        public string EpsfieldName { get; set; }
        public string EpsfieldDescription { get; set; }
        public string EpsfieldType { get; set; }
        public int AttributeId { get; set; }
        public long EpstemplateId { get; set; }

        public virtual Epstemplate Epstemplate { get; set; }
        public virtual EpsproductionField EpsproductionField { get; set; }
    }
}
