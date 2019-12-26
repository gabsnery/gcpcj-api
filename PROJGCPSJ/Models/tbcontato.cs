using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbcontato
    {
        [Key]
        public int idtbcontato { get; set; }
        public string setortbcontato { get; set; }
        public string emailtbcontato { get; set; }
        public string descricaotbcontato { get; set; }
    }
}
