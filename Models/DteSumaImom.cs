﻿using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteSumaImom
    {
        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string CodiImpu { get; set; }
        public decimal? ValoImre { get; set; }
        public decimal? TasaImpu { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DteEncaDocu DteEncaDocu { get; set; }
    }
}
