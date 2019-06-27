using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class CaraGene
    {
        public CaraGene()
        {
            ValoCage = new HashSet<ValoCage>();
        }

        public string CodiCage { get; set; }
        public string DescCage { get; set; }
        public string TipoCage { get; set; }
        public string IndiClie { get; set; }
        public string IndiProv { get; set; }
        public string IndiEmpl { get; set; }
        public string IndiEmpr { get; set; }

        public virtual ICollection<ValoCage> ValoCage { get; set; }
    }
}
