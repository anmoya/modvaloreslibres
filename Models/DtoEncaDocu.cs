using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DtoEncaDocu
    {
        public DtoEncaDocu()
        {
            DtoDescReca = new HashSet<DtoDescReca>();
            DtoDetaAcec = new HashSet<DtoDetaAcec>();
            DtoDetaPrse = new HashSet<DtoDetaPrse>();
            DtoDocuRefe = new HashSet<DtoDocuRefe>();
            DtoSumaImpu = new HashSet<DtoSumaImpu>();
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
        public string MontBrut { get; set; }
        public string ModaPago { get; set; }
        public string FechVenc { get; set; }
        public decimal? DiasTepa { get; set; }
        public string CodiTepa { get; set; }
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
        public decimal? NumeImpr { get; set; }
        public DateTime? FechImpr { get; set; }
        public string UsuaImpr { get; set; }
        public string VigeDocu { get; set; }
        public string CodiPeri { get; set; }
        public string MnsgErro { get; set; }
        public decimal? IndiNore { get; set; }
        public decimal? SubtVese { get; set; }
        public string DireArch { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal? MontBase { get; set; }
        public string CodiEsap { get; set; }
        public DateTime? FechEsap { get; set; }
        public string UsuaEsap { get; set; }
        public string RazoEsap { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual DtoReceDocu CorrEnviNavigation { get; set; }
        public virtual DteEstaDocu EstaDocuNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual ICollection<DtoDescReca> DtoDescReca { get; set; }
        public virtual ICollection<DtoDetaAcec> DtoDetaAcec { get; set; }
        public virtual ICollection<DtoDetaPrse> DtoDetaPrse { get; set; }
        public virtual ICollection<DtoDocuRefe> DtoDocuRefe { get; set; }
        public virtual ICollection<DtoSumaImpu> DtoSumaImpu { get; set; }
    }
}
