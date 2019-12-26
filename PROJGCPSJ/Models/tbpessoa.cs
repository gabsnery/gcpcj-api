using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbpessoa
    {
        public tbpessoa()
        {
            tbarqv = new HashSet<tbarqv>();
            tbhistrc = new HashSet<tbhistrc>();
            tbpermissvisulzc = new HashSet<tbpermissvisulzc>();
            tbpermss = new HashSet<tbpermss>();
        }
        [Key]
        public int idtbpessoa { get; set; }
        public string nometbpessoa { get; set; }
        public string sobrenometbpessoa { get; set; }
        public string documentotbpessoa { get; set; }
        public string isrespnsvlagenctbpessoa { get; set; }
        public int tbcargo_idtbcargo { get; set; }
        public int tbarea_idtbarea { get; set; }

        public virtual tbarea tbarea_idtbareaNavigation { get; set; }
        public virtual tbcargo tbcargo_idtbcargoNavigation { get; set; }
        public virtual ICollection<tbarqv> tbarqv { get; set; }
        public virtual ICollection<tbhistrc> tbhistrc { get; set; }
        public virtual ICollection<tbpermissvisulzc> tbpermissvisulzc { get; set; }
        public virtual ICollection<tbpermss> tbpermss { get; set; }
    }
}
