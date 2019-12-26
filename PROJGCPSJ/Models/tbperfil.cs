using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbperfil
    {
        public tbperfil()
        {
            tbpermss = new HashSet<tbpermss>();
        }
        [Key]
        public int idtbperfil { get; set; }
        public string descricaotbperfil { get; set; }

        public virtual ICollection<tbpermss> tbpermss { get; set; }
    }
}
