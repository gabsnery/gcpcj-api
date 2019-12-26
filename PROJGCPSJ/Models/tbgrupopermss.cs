using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbgrupopermss
    {
        public tbgrupopermss()
        {
            tbpermss = new HashSet<tbpermss>();
        }
        [Key]
        public int idtbgrupopermss { get; set; }
        public string descricaotbgrupopermss { get; set; }

        public virtual ICollection<tbpermss> tbpermss { get; set; }
    }
}
