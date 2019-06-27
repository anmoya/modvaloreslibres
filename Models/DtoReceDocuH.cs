using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoReceDocuH
    {
        public decimal? CodiEmpr { get; set; }
        public decimal CorrEnvi { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public decimal? RuttEnvi { get; set; }
        public string DigiEnvi { get; set; }
        public string FehoEnvi { get; set; }
        public string VersEnvi { get; set; }
        public string EstaEnvi { get; set; }
        public string MensEnvi { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public decimal? NumeReso { get; set; }
        public string FechReso { get; set; }
        public decimal? PosiEnvi { get; set; }
        public string BlocEnvi { get; set; }
        public string NombArch { get; set; }
        public string IndeEnvi { get; set; }
        public string FirmEnvi { get; set; }
        public string DireArch { get; set; }
        public string FechRece { get; set; }
        public string DigiValu { get; set; }
    }
}
