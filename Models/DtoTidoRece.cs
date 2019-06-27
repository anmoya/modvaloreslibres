using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoTidoRece
    {
        public decimal CorrEnvi { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal? CantDocu { get; set; }
        public decimal? CantInfo { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }

        public virtual DtoReceDocu CorrEnviNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
    }
}
