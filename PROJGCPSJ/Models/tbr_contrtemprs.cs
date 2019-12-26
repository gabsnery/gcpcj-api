using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbr_contrtemprs
    {
        [Key]
        public int idtbr_contrtemprs { get; set; }
        public int tbendereco_idtbendereco { get; set; }
        public int tbempresa_idtbempresa { get; set; }

        public virtual tbempresa tbempresa_idtbempresaNavigation { get; set; }
        public virtual tbendereco tbendereco_idtbenderecoNavigation { get; set; }
    }
}
