using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnListRepo
    {
        public DbnListRepo()
        {
            DbnListBoto = new HashSet<DbnListBoto>();
            DbnListColu = new HashSet<DbnListColu>();
            DbnRepoRous = new HashSet<DbnRepoRous>();
        }

        public string CodiRepo { get; set; }
        public string TituRepo { get; set; }
        public string DescRepo { get; set; }
        public string CodiResx { get; set; }
        public string ProcRepo { get; set; }
        public string CodiModu { get; set; }
        public string ScrpSqls { get; set; }
        public string ScrpSqlo { get; set; }
        public string FiltCkbb { get; set; }
        public string PageRepo { get; set; }
        public string Modo { get; set; }
        public string CateList { get; set; }
        public string TipoRepo { get; set; }
        public string SubtCntx { get; set; }
        public string MensErro { get; set; }

        public virtual ICollection<DbnListBoto> DbnListBoto { get; set; }
        public virtual ICollection<DbnListColu> DbnListColu { get; set; }
        public virtual ICollection<DbnRepoRous> DbnRepoRous { get; set; }
    }
}
