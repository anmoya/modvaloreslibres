using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class DteCesiDocu
    {
        public DteCesiDocu()
        {
            DteCesiAuto = new HashSet<DteCesiAuto>();
        }

        public decimal CodiEmpr { get; set; }
        public decimal CorrCesi { get; set; }
        public decimal? TipoDocu { get; set; }
        public decimal? FoliDocu { get; set; }
        public decimal? NumeCesi { get; set; }
        public decimal? RuttEmis { get; set; }
        public string DigiEmis { get; set; }
        public string NombEmis { get; set; }
        public decimal? RuttRece { get; set; }
        public string DigiRece { get; set; }
        public string NombRece { get; set; }
        public string FechEmis { get; set; }
        public string EstaDocu { get; set; }
        public decimal? MontTota { get; set; }
        public decimal? RuttCede { get; set; }
        public string DigiCede { get; set; }
        public string NombCede { get; set; }
        public string DireCede { get; set; }
        public string MailCede { get; set; }
        public string DeclJura { get; set; }
        public decimal? RuttCesi { get; set; }
        public string DigiCesi { get; set; }
        public string NombCesi { get; set; }
        public string DireCesi { get; set; }
        public string MailCesi { get; set; }
        public decimal? MontCesi { get; set; }
        public string FechVenc { get; set; }
        public string OtraCond { get; set; }
        public string MailDeud { get; set; }
        public decimal? RuttEnvi { get; set; }
        public string TimeEnvi { get; set; }
        public string ArchCesi { get; set; }
        public string FechUpld { get; set; }
        public decimal? NumeAten { get; set; }
        public string MensEnvi { get; set; }
        public decimal? NumeEnvi { get; set; }
        public string DigiEnvi { get; set; }

        public virtual DteEstaCesi EstaDocuNavigation { get; set; }
        public virtual DteTipoDocu TipoDocuNavigation { get; set; }
        public virtual ICollection<DteCesiAuto> DteCesiAuto { get; set; }
    }
}
