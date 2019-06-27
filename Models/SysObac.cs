using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysObac
    {
        public decimal CodiActi { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectProg { get; set; }
        public decimal? OrdeObac { get; set; }
        public string ObseObac { get; set; }
        public string EstaObac { get; set; }
        public string TipoObac { get; set; }
        public DateTime? FechObac { get; set; }

        public virtual SysObject ObjectNameNavigation { get; set; }
    }
}
