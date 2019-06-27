using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Models
{
    public partial class SysComment
    {
        public string ObjectProg { get; set; }
        public string ObjectType { get; set; }
        public decimal CommentLine { get; set; }
        public string CommentText { get; set; }
        public string CommentType { get; set; }
    }
}
