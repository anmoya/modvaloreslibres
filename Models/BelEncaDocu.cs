using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class BelEncaDocu
    {
        public BelEncaDocu()
        {
            BelDatoRefe = new HashSet<BelDatoRefe>();
            BelDescReca = new HashSet<BelDescReca>();
            BelDetaPrse = new HashSet<BelDetaPrse>();
            BelInfoTick = new HashSet<BelInfoTick>();
            BelSubtInfo = new HashSet<BelSubtInfo>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal TipoDocu { get; set; }
        public decimal FoliDocu { get; set; }
        public string VersEnca { get; set; }
        public decimal? CorrEnvi { get; set; }
        public decimal? CorrRafo { get; set; }
        public string EstaDocu { get; set; }
        public string FechEmis { get; set; }
        public decimal IndiServ { get; set; }
        public decimal? IndiMone { get; set; }
        public string PediDesd { get; set; }
        public string PeriHast { get; set; }
        public string FechVenc { get; set; }
        public decimal RuttEmis { get; set; }
        public string DigiVeri { get; set; }
        public string NombEmis { get; set; }
        public string GiroEmis { get; set; }
        public decimal? CodiSucu { get; set; }
        public string DireOrig { get; set; }
        public string ComuOrig { get; set; }
        public string CiudOrig { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public string CodiInte { get; set; }
        public string NombRece { get; set; }
        public string ContRece { get; set; }
        public string DireRece { get; set; }
        public string ComuRece { get; set; }
        public string CiudRece { get; set; }
        public string DirePost { get; set; }
        public string ComuPost { get; set; }
        public string CiudPost { get; set; }
        public decimal? MontNeto { get; set; }
        public decimal? MontExen { get; set; }
        public decimal? TasaVaag { get; set; }
        public decimal MontTota { get; set; }
        public decimal? MontNofa { get; set; }
        public decimal? TotaPeri { get; set; }
        public decimal? SaldAnte { get; set; }
        public decimal? ValoPaga { get; set; }
        public string TmstTimb { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public string Val3 { get; set; }
        public string Val4 { get; set; }
        public string Val5 { get; set; }
        public string Val6 { get; set; }
        public string Val7 { get; set; }
        public string Val8 { get; set; }
        public string Val9 { get; set; }
        public string Val10 { get; set; }
        public string ColaProc { get; set; }
        public string ImprDest { get; set; }
        public decimal? NumeImpr { get; set; }
        public string FoliClie { get; set; }
        public decimal? VaagTerc { get; set; }

        public virtual Empr CodiEmprNavigation { get; set; }
        public virtual BelEnviDocu CorrEnviNavigation { get; set; }
        public virtual DteRangFoli CorrRafoNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual BelXml BelXml { get; set; }
        public virtual ICollection<BelDatoRefe> BelDatoRefe { get; set; }
        public virtual ICollection<BelDescReca> BelDescReca { get; set; }
        public virtual ICollection<BelDetaPrse> BelDetaPrse { get; set; }
        public virtual ICollection<BelInfoTick> BelInfoTick { get; set; }
        public virtual ICollection<BelSubtInfo> BelSubtInfo { get; set; }
    }
}
