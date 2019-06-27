using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeCaraLibr
    {
        public LbeCaraLibr()
        {
            LbeDetaLibr = new HashSet<LbeDetaLibr>();
            LbeResuPeri = new HashSet<LbeResuPeri>();
            LbeResuSegm = new HashSet<LbeResuSegm>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrLibe { get; set; }
        public decimal? FoliNoti { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public decimal? RuttEnvi { get; set; }
        public string DigiEnvi { get; set; }
        public string PeriTrib { get; set; }
        public string FechReso { get; set; }
        public decimal? NumeReso { get; set; }
        public string TipoLibr { get; set; }
        public string TipoEnvi { get; set; }
        public decimal? NumeSegm { get; set; }
        public string FechCrea { get; set; }
        public string FechInic { get; set; }
        public string FechFina { get; set; }
        public string FechEnvi { get; set; }

        public virtual LbeNotiLibr LbeNotiLibr { get; set; }
        public virtual ICollection<LbeDetaLibr> LbeDetaLibr { get; set; }
        public virtual ICollection<LbeResuPeri> LbeResuPeri { get; set; }
        public virtual ICollection<LbeResuSegm> LbeResuSegm { get; set; }
    }
}
