using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbarea
    {
        public tbarea()
        {
            tbcontrato = new HashSet<tbcontrato>();
            tbpermissvisulzc = new HashSet<tbpermissvisulzc>();
            tbpessoa = new HashSet<tbpessoa>();
        }
        [Key]
        public int idtbarea { get; set; }
        public string nometbarea { get; set; }

        public virtual ICollection<tbcontrato> tbcontrato { get; set; }
        public virtual ICollection<tbpermissvisulzc> tbpermissvisulzc { get; set; }
        public virtual ICollection<tbpessoa> tbpessoa { get; set; }
    }
}
