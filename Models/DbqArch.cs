using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbqArch
    {
        public decimal CodiArch { get; set; }
        public decimal? CodiGrpo { get; set; }
        public string EstaArch { get; set; }
        public string CtrlArch { get; set; }
        public string CodiServ { get; set; }
        public string CodiServOrig { get; set; }
        public DateTime TmstRegiArch { get; set; }
        public DateTime TmstProcArch { get; set; }
        public decimal ContProcArch { get; set; }
        public string NombArch { get; set; }
        public string ExteArch { get; set; }
        public string TipoArch { get; set; }
        public string SubtArch { get; set; }
        public string TablRela { get; set; }
        public string Pk01Tabl { get; set; }
        public string Pk02Tabl { get; set; }
        public string Pk03Tabl { get; set; }
        public string Pk04Tabl { get; set; }
        public string Pk05Tabl { get; set; }
        public string Pk06Tabl { get; set; }
        public string TablEsta { get; set; }
        public string UltiErro { get; set; }
        public string TipoRegi { get; set; }
    }
}
