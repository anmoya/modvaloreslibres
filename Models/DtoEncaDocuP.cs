using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoEncaDocuP
    {
        public DtoEncaDocuP()
        {
            DtoDescRecaP = new HashSet<DtoDescRecaP>();
            DtoDetaAcecP = new HashSet<DtoDetaAcecP>();
            DtoDetaPrseP = new HashSet<DtoDetaPrseP>();
            DtoDocuRefeP = new HashSet<DtoDocuRefeP>();
            DtoSumaImpuP = new HashSet<DtoSumaImpuP>();
        }

        public decimal? CodiEmpr { get; set; }
        public decimal CorrDocu { get; set; }
        public string TipoDocu { get; set; }
        public string FoliDocu { get; set; }
        public string EstaDocu { get; set; }
        public string MensEsta { get; set; }
        public decimal? CorrEnvi { get; set; }
        public string MensEnvi { get; set; }
        public string VersEnca { get; set; }
        public string FechEmis { get; set; }
        public string EntrBien { get; set; }
        public string IndiVegd { get; set; }
        public string VentServ { get; set; }
        public string MontBrut { get; set; }
        public string FormPago { get; set; }
        public string FechCanc { get; set; }
        public string PeriDesd { get; set; }
        public string PeriHast { get; set; }
        public string ModaPago { get; set; }
        public string DiasTepa { get; set; }
        public string FechVenc { get; set; }
        public string CodiTepa { get; set; }
        public string RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string NombEmis { get; set; }
        public string GiroEmis { get; set; }
        public string NombSucu { get; set; }
        public string CodiSucu { get; set; }
        public string DireOrig { get; set; }
        public string ComuOrig { get; set; }
        public string CiudOrig { get; set; }
        public string CodiVend { get; set; }
        public string RuttMand { get; set; }
        public string DigiMand { get; set; }
        public string RuttRece { get; set; }
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
        public string RuttSofa { get; set; }
        public string DigiSofa { get; set; }
        public string InfoTran { get; set; }
        public string RuttTran { get; set; }
        public string DigiTran { get; set; }
        public string DireDest { get; set; }
        public string ComuDest { get; set; }
        public string CiudDest { get; set; }
        public string MontNeto { get; set; }
        public string MontExen { get; set; }
        public string ImpuVaag { get; set; }
        public string ImpuVanr { get; set; }
        public string CredEs65 { get; set; }
        public string GaraEnva { get; set; }
        public string MontTota { get; set; }
        public string MontNofa { get; set; }
        public string ValoPaga { get; set; }
        public string SaldAnte { get; set; }
        public string CodiCeco { get; set; }
        public string FehoFirm { get; set; }
        public string FehoTed { get; set; }
        public string FirmTed { get; set; }
        public string CorrRafo { get; set; }
        public DateTime? FechCarg { get; set; }
        public string MnsgErro { get; set; }
        public decimal? IndiNore { get; set; }
        public decimal? SubtVese { get; set; }
        public string DireArch { get; set; }
        public string TasaVaag { get; set; }
        public string MontBase { get; set; }
        public decimal? NumeImpr { get; set; }
        public string CodiEsap { get; set; }
        public DateTime? FechEsap { get; set; }
        public string UsuaEsap { get; set; }
        public string RazoEsap { get; set; }
        public string EstaTras { get; set; }
        public string ReciRece { get; set; }
        public string CodiUsuaApro { get; set; }
        public string MailUsuaApro { get; set; }
        public string IndiCont { get; set; }
        public string IndiConta { get; set; }
        public string CodiServ { get; set; }
        public string CodiEmex { get; set; }
        public int? PeriPart { get; set; }
        public string CodiReme { get; set; }
        public DateTime? FechReme { get; set; }
        public string UsuaReme { get; set; }
        public decimal? FoliNume { get; set; }
        public string EvenRecl { get; set; }
        public string UsuaRecl { get; set; }
        public DateTime? FechRecl { get; set; }
        public string CsiiRecl { get; set; }
        public DateTime? FechReceSii { get; set; }

        public virtual DtoReceDocu CorrEnviNavigation { get; set; }
        public virtual ICollection<DtoDescRecaP> DtoDescRecaP { get; set; }
        public virtual ICollection<DtoDetaAcecP> DtoDetaAcecP { get; set; }
        public virtual ICollection<DtoDetaPrseP> DtoDetaPrseP { get; set; }
        public virtual ICollection<DtoDocuRefeP> DtoDocuRefeP { get; set; }
        public virtual ICollection<DtoSumaImpuP> DtoSumaImpuP { get; set; }
    }
}
