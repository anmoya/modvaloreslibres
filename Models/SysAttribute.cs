using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysAttribute
    {
        public SysAttribute()
        {
            SysAttrCult = new HashSet<SysAttrCult>();
        }

        public string AttrName { get; set; }
        public string ObjectName { get; set; }
        public string AttrBrief { get; set; }
        public string AttrDesc { get; set; }
        public string AttrType { get; set; }
        public decimal? AttrLength { get; set; }
        public decimal? AttrPrec { get; set; }
        public decimal? AttrScale { get; set; }
        public string AttrMand { get; set; }
        public decimal? AttrOrder { get; set; }
        public string AttrDefault { get; set; }
        public decimal? DomainCode { get; set; }
        public decimal? CondDomain { get; set; }
        public string CondAttr { get; set; }
        public string AttrState { get; set; }
        public DateTime? AttrDate { get; set; }
        public string AttrRela { get; set; }
        public string AttrStruct { get; set; }
        public string AttrTag { get; set; }
        public string AttrKey { get; set; }

        public virtual ICollection<SysAttrCult> SysAttrCult { get; set; }
    }
}
