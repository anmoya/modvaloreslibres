using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class EmprExte
    {
        public EmprExte()
        {
            QseDocuServ = new HashSet<QseDocuServ>();
            UsemExte = new HashSet<UsemExte>();
            UsuaExte = new HashSet<UsuaExte>();
        }

        public string CodiEmex { get; set; }
        public string NombEmex { get; set; }
        public string StatEmex { get; set; }
        public DateTime FeinEmex { get; set; }
        public DateTime? FeteEmex { get; set; }
        public string OwneEmex { get; set; }
        public string PassEmex { get; set; }
        public string PathEmex { get; set; }
        public string HeadEmex { get; set; }
        public string SideEmex { get; set; }
        public string BackEmex { get; set; }
        public string SplaEmex { get; set; }
        public string LogoEmex { get; set; }
        public string SwebEmex { get; set; }
        public string BannEmex { get; set; }
        public string UrbaEmex { get; set; }
        public string GintEmex { get; set; }
        public string IntrEmex { get; set; }
        public decimal? CodiEmpr { get; set; }
        public string PagiInic { get; set; }
        public string StriConn { get; set; }
        public string HabiSiti { get; set; }
        public string ColoEmex { get; set; }
        public string ComeEmex { get; set; }
        public string FormEmex { get; set; }
        public string ServSweb { get; set; }
        public string ServSrep { get; set; }
        public string ServScgi { get; set; }
        public string IpwsEmex { get; set; }
        public string PtwsEmex { get; set; }
        public string UsuaDbss { get; set; }
        public string UsuaWeb { get; set; }
        public string PassUsuaWeb { get; set; }
        public string UsuaEul { get; set; }
        public string PassUsuaEul { get; set; }
        public string RepoEmex { get; set; }
        public string EmexRef { get; set; }
        public string EmexBody { get; set; }
        public string EmexFrom { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual ICollection<QseDocuServ> QseDocuServ { get; set; }
        public virtual ICollection<UsemExte> UsemExte { get; set; }
        public virtual ICollection<UsuaExte> UsuaExte { get; set; }
    }
}
