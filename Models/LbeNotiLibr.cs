using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class LbeNotiLibr
    {
        public LbeNotiLibr()
        {
            LbeCaraLibr = new HashSet<LbeCaraLibr>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal FoliNoti { get; set; }
        public string FechNoti { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public string DescLibr { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual ICollection<LbeCaraLibr> LbeCaraLibr { get; set; }
    }
}
