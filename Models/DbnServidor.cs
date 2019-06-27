using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnServidor
    {
        public DbnServidor()
        {
            DbnServSrvd = new HashSet<DbnServSrvd>();
        }

        public string ServServ { get; set; }
        public string ServDesc { get; set; }

        public virtual ICollection<DbnServSrvd> DbnServSrvd { get; set; }
    }
}
