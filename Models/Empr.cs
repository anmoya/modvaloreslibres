using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class Empr
    {
        public Empr()
        {
            BelConsCara = new HashSet<BelConsCara>();
            BelEncaDocu = new HashSet<BelEncaDocu>();
            BelEnviDocu = new HashSet<BelEnviDocu>();
            BelFoliAnul = new HashSet<BelFoliAnul>();
            BelTidoEnvi = new HashSet<BelTidoEnvi>();
            CaraPeem = new HashSet<CaraPeem>();
            CentCost = new HashSet<CentCost>();
            DteAcecEmpr = new HashSet<DteAcecEmpr>();
            DteDelCesion = new HashSet<DteDelCesion>();
            DteEncaDocu = new HashSet<DteEncaDocu>();
            DteEncaDocuH = new HashSet<DteEncaDocuH>();
            DteEnviDocu = new HashSet<DteEnviDocu>();
            DteEnviDocuH = new HashSet<DteEnviDocuH>();
            DteEnviLob = new HashSet<DteEnviLob>();
            DteEnviLobH = new HashSet<DteEnviLobH>();
            DteRangFoli = new HashSet<DteRangFoli>();
            DtoDocuLob = new HashSet<DtoDocuLob>();
            DtoDocuLobH = new HashSet<DtoDocuLobH>();
            DtoEncaDocu = new HashSet<DtoEncaDocu>();
            DtoReceLob = new HashSet<DtoReceLob>();
            DtoReceLobH = new HashSet<DtoReceLobH>();
            EmprExte = new HashSet<EmprExte>();
            FoliAnul = new HashSet<FoliAnul>();
            LbeNotiLibr = new HashSet<LbeNotiLibr>();
            LcvDigiDocu = new HashSet<LcvDigiDocu>();
            OficEmpr = new HashSet<OficEmpr>();
            ParaPers = new HashSet<ParaPers>();
            Personas = new HashSet<Personas>();
            Ramo = new HashSet<Ramo>();
            UsuaEmpr = new HashSet<UsuaEmpr>();
            UsuaExte = new HashSet<UsuaExte>();
        }

        public decimal CodiEmpr { get; set; }
        public string NombEmpr { get; set; }
        public string GiroEmpr { get; set; }
        public string DireEmpr { get; set; }
        public string CodiComu { get; set; }
        public string CodiCiud { get; set; }
        public decimal? RuttEmpr { get; set; }
        public string DigiEmpr { get; set; }
        public string CodiRamo { get; set; }
        public string NfanEmpr { get; set; }
        public string CodiPers { get; set; }
        public decimal? EmprCodg { get; set; }
        public string EmprNomb { get; set; }
        public string FonoEmpr { get; set; }
        public decimal? RuttRepl { get; set; }
        public string DgtoRepl { get; set; }
        public string NombRepl { get; set; }
        public string CacaEmpr { get; set; }
        public string MutuEmpr { get; set; }
        public decimal? PomuEmpr { get; set; }
        public decimal? PocaEmpr { get; set; }
        public DateTime? FecaEmpr { get; set; }
        public DateTime? FemuEmpr { get; set; }
        public string CineEmpr { get; set; }
        public string CuenEmpr { get; set; }
        public string CajaEmpr { get; set; }
        public string ColorEmpr { get; set; }
        public string LogoEmpr { get; set; }
        public string ClavEncr { get; set; }
        public string AsunFactEmpr { get; set; }
        public string TextFactEmpr { get; set; }
        public string CodiEmex { get; set; }

        public virtual Personas CodiPersNavigation { get; set; }
        public virtual ICollection<BelConsCara> BelConsCara { get; set; }
        public virtual ICollection<BelEncaDocu> BelEncaDocu { get; set; }
        public virtual ICollection<BelEnviDocu> BelEnviDocu { get; set; }
        public virtual ICollection<BelFoliAnul> BelFoliAnul { get; set; }
        public virtual ICollection<BelTidoEnvi> BelTidoEnvi { get; set; }
        public virtual ICollection<CaraPeem> CaraPeem { get; set; }
        public virtual ICollection<CentCost> CentCost { get; set; }
        public virtual ICollection<DteAcecEmpr> DteAcecEmpr { get; set; }
        public virtual ICollection<DteDelCesion> DteDelCesion { get; set; }
        public virtual ICollection<DteEncaDocu> DteEncaDocu { get; set; }
        public virtual ICollection<DteEncaDocuH> DteEncaDocuH { get; set; }
        public virtual ICollection<DteEnviDocu> DteEnviDocu { get; set; }
        public virtual ICollection<DteEnviDocuH> DteEnviDocuH { get; set; }
        public virtual ICollection<DteEnviLob> DteEnviLob { get; set; }
        public virtual ICollection<DteEnviLobH> DteEnviLobH { get; set; }
        public virtual ICollection<DteRangFoli> DteRangFoli { get; set; }
        public virtual ICollection<DtoDocuLob> DtoDocuLob { get; set; }
        public virtual ICollection<DtoDocuLobH> DtoDocuLobH { get; set; }
        public virtual ICollection<DtoEncaDocu> DtoEncaDocu { get; set; }
        public virtual ICollection<DtoReceLob> DtoReceLob { get; set; }
        public virtual ICollection<DtoReceLobH> DtoReceLobH { get; set; }
        public virtual ICollection<EmprExte> EmprExte { get; set; }
        public virtual ICollection<FoliAnul> FoliAnul { get; set; }
        public virtual ICollection<LbeNotiLibr> LbeNotiLibr { get; set; }
        public virtual ICollection<LcvDigiDocu> LcvDigiDocu { get; set; }
        public virtual ICollection<OficEmpr> OficEmpr { get; set; }
        public virtual ICollection<ParaPers> ParaPers { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }
        public virtual ICollection<Ramo> Ramo { get; set; }
        public virtual ICollection<UsuaEmpr> UsuaEmpr { get; set; }
        public virtual ICollection<UsuaExte> UsuaExte { get; set; }
    }
}
