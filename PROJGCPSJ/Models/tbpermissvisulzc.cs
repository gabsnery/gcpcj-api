using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbpermissvisulzc
    {
        [Key]
        public int idpermissvisulzc { get; set; }
        public DateTime? datapermissvisulzc { get; set; }
        public DateTime? validadepermissvisulzc { get; set; }
        public int? idtbarea { get; set; }
        public int? idcontrato { get; set; }
        public int? idpessrespnsvl { get; set; }

        public virtual tbcontrato idcontratoNavigation { get; set; }
        public virtual tbpessoa idpessrespnsvlNavigation { get; set; }
        public virtual tbarea idtbareaNavigation { get; set; }
    }
}
