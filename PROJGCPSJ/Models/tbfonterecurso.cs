using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbfonterecurso
    {
        public tbfonterecurso()
        {
            tbaditivo = new HashSet<tbaditivo>();
            tbcontrato = new HashSet<tbcontrato>();
        }
        [Key]
        public int idtbfonterecurso { get; set; }
        public string descricaotbfonterecurso { get; set; }

        public virtual ICollection<tbaditivo> tbaditivo { get; set; }
        public virtual ICollection<tbcontrato> tbcontrato { get; set; }
    }
}
