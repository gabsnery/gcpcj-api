using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbcargo
    {
        public tbcargo()
        {
            tbpessoa = new HashSet<tbpessoa>();
        }
        [Key]
        public int idtbcargo { get; set; }
        public string descricaotbcargo { get; set; }
        public bool? isoficialtbcargo { get; set; }

        public virtual ICollection<tbpessoa> tbpessoa { get; set; }
    }
}
