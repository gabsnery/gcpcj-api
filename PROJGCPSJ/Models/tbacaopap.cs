using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbacaopap
    {
        public tbacaopap()
        {
            tbaditivo = new HashSet<tbaditivo>();
            tbcontrato = new HashSet<tbcontrato>();
        }
        [Key]
        public int idacaopap { get; set; }
        public string papacaopap { get; set; }
        public string acaosubacaopap { get; set; }

        public virtual ICollection<tbaditivo> tbaditivo { get; set; }
        public virtual ICollection<tbcontrato> tbcontrato { get; set; }
    }
}
