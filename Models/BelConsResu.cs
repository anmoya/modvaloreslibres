using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelConsResu
    {
        public BelConsResu()
        {
            BelConsRang = new HashSet<BelConsRang>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrCons { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? TotaNeto { get; set; }
        public decimal? TotaIvag { get; set; }
        public decimal? TasaIvag { get; set; }
        public decimal? TotaExen { get; set; }
        public decimal MontTota { get; set; }
        public decimal CantEmit { get; set; }
        public decimal CantAnul { get; set; }
        public decimal CantUtil { get; set; }

        public virtual BelConsCara Co { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual ICollection<BelConsRang> BelConsRang { get; set; }
    }
}
