using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbempresa
    {
        public tbempresa()
        {
            tbr_contrtemprs = new HashSet<tbr_contrtemprs>();
        }
        [Key]
        public int idtbempresa { get; set; }
        public string razaotbempresa { get; set; }
        public string nomefantasiatbempresa { get; set; }

        public virtual ICollection<tbr_contrtemprs> tbr_contrtemprs { get; set; }
    }
}
