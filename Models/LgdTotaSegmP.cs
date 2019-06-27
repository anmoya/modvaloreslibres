using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LgdTotaSegmP
    {
        public LgdTotaSegmP()
        {
            LgdTrasSegmP = new HashSet<LgdTrasSegmP>();
        }

        public decimal CorrLigd { get; set; }
        public decimal CodiEmpr { get; set; }
        public string NumeFoan { get; set; }
        public string NumeGanu { get; set; }
        public string TotaGvta { get; set; }
        public string MontGvta { get; set; }
        public string MontModi { get; set; }
        public string CodiEmex { get; set; }

        public virtual LgdEncaLigdP Co { get; set; }
        public virtual ICollection<LgdTrasSegmP> LgdTrasSegmP { get; set; }
    }
}
