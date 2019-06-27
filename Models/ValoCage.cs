using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class ValoCage
    {
        public ValoCage()
        {
            CaraPeem = new HashSet<CaraPeem>();
        }

        public string CodiCage { get; set; }
        public string CodiVacg { get; set; }
        public string DescVacg { get; set; }

        public virtual CaraGene CodiCageNavigation { get; set; }
        public virtual ICollection<CaraPeem> CaraPeem { get; set; }
    }
}
