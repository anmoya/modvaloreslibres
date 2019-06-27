using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelSubtInfo
    {
        public BelSubtInfo()
        {
            BelDetaSubt = new HashSet<BelDetaSubt>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public string GlosSubt { get; set; }
        public decimal? OrdeImpr { get; set; }
        public decimal? ValoNeto { get; set; }
        public decimal? ValoIvag { get; set; }
        public decimal? ValoImad { get; set; }
        public decimal? ValoExen { get; set; }
        public decimal? ValoSubt { get; set; }
        public decimal? LineDeta { get; set; }

        public virtual BelEncaDocu BelEncaDocu { get; set; }
        public virtual ICollection<BelDetaSubt> BelDetaSubt { get; set; }
    }
}
