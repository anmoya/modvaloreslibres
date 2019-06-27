using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeSoliLibr
    {
        public LbeSoliLibr()
        {
            LbeEncaLibr = new HashSet<LbeEncaLibr>();
        }

        public decimal CodiSoli { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public decimal? MontMini { get; set; }
        public decimal? NumeDtes { get; set; }
        public decimal? FoliNoti { get; set; }

        public virtual ICollection<LbeEncaLibr> LbeEncaLibr { get; set; }
    }
}
