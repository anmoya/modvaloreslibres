using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Moneda
    {
        public string CodiMone { get; set; }
        public string NombMone { get; set; }
        public decimal? RounMone { get; set; }
        public string CodiPais { get; set; }
        public string NumeMone { get; set; }
        public string CodiMoneAnte { get; set; }
        public string FisoMone { get; set; }
        public decimal? UmoRound { get; set; }
        public string MndaCdg { get; set; }
        public string MndaNmb { get; set; }
    }
}
