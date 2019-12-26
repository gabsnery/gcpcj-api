using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbtipodemand
    {
        public tbtipodemand()
        {
            tbcontrato = new HashSet<tbcontrato>();
        }
        [Key]
        public int idtipodemand { get; set; }
        public string descricaotipodemand { get; set; }

        public virtual ICollection<tbcontrato> tbcontrato { get; set; }
    }
}
