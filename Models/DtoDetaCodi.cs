﻿using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoDetaCodi
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public decimal NumeLine { get; set; }
        public decimal CorrCodi { get; set; }
        public string TipoCodi { get; set; }
        public string CodiItem { get; set; }
        public string MnsgErro { get; set; }

        public virtual DtoDetaPrse DtoDetaPrse { get; set; }
    }
}
