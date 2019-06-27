using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DbnServSrvd
    {
        public DbnServSrvd()
        {
            DbnMoniProc = new HashSet<DbnMoniProc>();
            DbnSesrRangOper = new HashSet<DbnSesrRangOper>();
        }

        public string ServServ { get; set; }
        public string CodiServ { get; set; }
        public string EstaServ { get; set; }
        public decimal SleeServ { get; set; }
        public string DebuServ { get; set; }
        public decimal HvidServ { get; set; }
        public string ModoServ { get; set; }
        public string ComaServ { get; set; }
        public decimal? QcanProc { get; set; }

        public virtual DbnServicio CodiServNavigation { get; set; }
        public virtual DbnServidor ServServNavigation { get; set; }
        public virtual ICollection<DbnMoniProc> DbnMoniProc { get; set; }
        public virtual ICollection<DbnSesrRangOper> DbnSesrRangOper { get; set; }
    }
}
