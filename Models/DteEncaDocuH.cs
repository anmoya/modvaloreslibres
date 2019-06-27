using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteEncaDocuH
    {
        public DteEncaDocuH()
        {
            DteDescRecaH = new HashSet<DteDescRecaH>();
            DteDetaAcecH = new HashSet<DteDetaAcecH>();
            DteDetaPrseH = new HashSet<DteDetaPrseH>();
            DteDocuLobH = new HashSet<DteDocuLobH>();
            DteDocuRefeH = new HashSet<DteDocuRefeH>();
            DteSumaImpuH = new HashSet<DteSumaImpuH>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string EstaDocu { get; set; }
        public string MensEsta { get; set; }
        public decimal? CorrEnvi { get; set; }
        public string MensEnvi { get; set; }
        public string FechEmis { get; set; }
        public decimal? EntrBien { get; set; }
        public decimal? VentServ { get; set; }
        public decimal? FormPago { get; set; }
        public string FechCanc { get; set; }
        public decimal? DiasTepa { get; set; }
        public string CodiTepa { get; set; }
        public string MontBrut { get; set; }
        public string ModaPago { get; set; }
        public string FechVenc { get; set; }
        public decimal? RuttEmis { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public string DigiEmis { get; set; }
        public string NombEmis { get; set; }
        public string GiroEmis { get; set; }
        public string NombSucu { get; set; }
        public decimal? CodiSucu { get; set; }
        public string DireOrig { get; set; }
        public string ComuOrig { get; set; }
        public string CiudOrig { get; set; }
        public string CodiVend { get; set; }
        public decimal? RuttMand { get; set; }
        public string DigiMand { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public string NombRece { get; set; }
        public string CodiRece { get; set; }
        public string GiroRece { get; set; }
        public string ContRece { get; set; }
        public string DireRece { get; set; }
        public string ComuRece { get; set; }
        public string CiudRece { get; set; }
        public string DirePost { get; set; }
        public string ComuPost { get; set; }
        public string CiudPost { get; set; }
        public decimal? RuttSofa { get; set; }
        public string DigiSofa { get; set; }
        public string InfoTran { get; set; }
        public decimal? RuttTran { get; set; }
        public string DigiTran { get; set; }
        public string DireDest { get; set; }
        public string ComuDest { get; set; }
        public string CiudDest { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? ImpuVaag { get; set; }
        public decimal? ImpuVanr { get; set; }
        public decimal? CredEs65 { get; set; }
        public decimal? GaraEnva { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? ValoPaga { get; set; }
        public decimal? SaldAnte { get; set; }
        public string CodiCeco { get; set; }
        public string FehoFirm { get; set; }
        public decimal? IndiVegd { get; set; }
        public string VersEnca { get; set; }
        public decimal? CorrRafo { get; set; }
        public string FehoTed { get; set; }
        public string FirmTed { get; set; }
        public DateTime? FechCarg { get; set; }
        public string UsuaImpr { get; set; }
        public decimal? NumeImpr { get; set; }
        public DateTime? FechImpr { get; set; }
        public string VigeDocu { get; set; }
        public string CodiPeri { get; set; }
        public decimal? CorrEnvi1 { get; set; }
        public string EstaDocu1 { get; set; }
        public string MnsgErro { get; set; }
        public decimal? IndiNore { get; set; }
        public decimal? SubtVese { get; set; }
        public string DireArch { get; set; }
        public string ImprDest { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
        public string Val4 { get; set; }
        public string Val5 { get; set; }
        public string Val6 { get; set; }
        public string Val7 { get; set; }
        public string Val8 { get; set; }
        public string Val9 { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal? MontBase { get; set; }
        public string ColaProc { get; set; }
        public decimal? NumeImme { get; set; }
        public string ArchResp { get; set; }
        public string HaceEnvi { get; set; }
        public string TipoImpr { get; set; }
        public decimal? MontCanc { get; set; }
        public decimal? SaldInso { get; set; }
        public decimal? FromPaex { get; set; }
        public decimal? TipoCupa { get; set; }
        public decimal? CuenPago { get; set; }
        public string BancPago { get; set; }
        public string GlosPago { get; set; }
        public decimal? CodiEmtr { get; set; }
        public decimal? FoliAuto { get; set; }
        public string FechAuto { get; set; }
        public string CodiSuad { get; set; }
        public string IdenAdem { get; set; }
        public string IdenReex { get; set; }
        public string NaciExt { get; set; }
        public string IdenAdre { get; set; }
        public string MailRece { get; set; }
        public decimal? RuttChof { get; set; }
        public string DigiChof { get; set; }
        public string NombChof { get; set; }
        public decimal? ModaVent { get; set; }
        public decimal? ClauExpo { get; set; }
        public decimal? TotaClex { get; set; }
        public decimal? ViaaTran { get; set; }
        public string NombTran { get; set; }
        public decimal? RuttCitr { get; set; }
        public string DigiCitr { get; set; }
        public string NombCitr { get; set; }
        public string IdenCitr { get; set; }
        public string NumeBook { get; set; }
        public string CodiOper { get; set; }
        public decimal? CodiPuem { get; set; }
        public string IdenPuem { get; set; }
        public decimal? CodiPude { get; set; }
        public string IdenPude { get; set; }
        public decimal? CantTara { get; set; }
        public decimal? UmedTara { get; set; }
        public decimal? TotaBrut { get; set; }
        public decimal? UnidBrut { get; set; }
        public decimal? TotaNeto { get; set; }
        public decimal? UnidNeto { get; set; }
        public decimal? TotaItem { get; set; }
        public decimal? TotaBult { get; set; }
        public decimal? MontFlet { get; set; }
        public decimal? MontSegu { get; set; }
        public string PaisRece { get; set; }
        public string PaisDest { get; set; }
        public string TipoMone { get; set; }
        public decimal? MontBaco { get; set; }
        public decimal? IvagProp { get; set; }
        public decimal? IvagTerc { get; set; }
        public decimal? ValoCone { get; set; }
        public decimal? ValoCoex { get; set; }
        public decimal? IvaagCore { get; set; }
        public string TipoMoom { get; set; }
        public decimal? TipoCamb { get; set; }
        public decimal? NetoOtmo { get; set; }
        public decimal? NoafOtmo { get; set; }
        public decimal? FacaOtmo { get; set; }
        public decimal? MacoOtmo { get; set; }
        public decimal? IvagOtmo { get; set; }
        public decimal? IvnoOtmo { get; set; }
        public decimal? MontOtmo { get; set; }
        public decimal? CorrExtr { get; set; }
        public string FoliClie { get; set; }
        public string TipoMoto { get; set; }
        public string CodiMone { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DteEnviDocuH CorrEnvi1Navigation { get; set; }
        public virtual DteRangFoli CorrRafoNavigation { get; set; }
        public virtual DteEstaDocu EstaDocuNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual ICollection<DteDescRecaH> DteDescRecaH { get; set; }
        public virtual ICollection<DteDetaAcecH> DteDetaAcecH { get; set; }
        public virtual ICollection<DteDetaPrseH> DteDetaPrseH { get; set; }
        public virtual ICollection<DteDocuLobH> DteDocuLobH { get; set; }
        public virtual ICollection<DteDocuRefeH> DteDocuRefeH { get; set; }
        public virtual ICollection<DteSumaImpuH> DteSumaImpuH { get; set; }
    }
}
