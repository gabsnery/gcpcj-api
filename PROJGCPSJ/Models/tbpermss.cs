using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbpermss
    {
        [Key]
        public int idtbpermss { get; set; }
        public int tbpessoa_idtbpessoa { get; set; }
        public int tbperfil_idtbperfil { get; set; }
        public int tbgrupopermss_idtbgrupopermss { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }

        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
        public virtual tbgrupopermss tbgrupopermss_idtbgrupopermssNavigation { get; set; }
        public virtual tbperfil tbperfil_idtbperfilNavigation { get; set; }
        public virtual tbpessoa tbpessoa_idtbpessoaNavigation { get; set; }
    }
}
