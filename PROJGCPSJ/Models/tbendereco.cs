using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbendereco
    {
        public tbendereco()
        {
            tbr_contrtemprs = new HashSet<tbr_contrtemprs>();
        }
        [Key]
        public int idtbendereco { get; set; }
        public string enderecotbendereco { get; set; }
        public string cidadetbendereco { get; set; }
        public string ceptbendereco { get; set; }
        public string ibgetbendereco { get; set; }

        public virtual ICollection<tbr_contrtemprs> tbr_contrtemprs { get; set; }
    }
}
