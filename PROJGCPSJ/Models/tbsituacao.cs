using System; using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbsituacao
    {
        [Key]
        public int idtbsituacao { get; set; }
        public string descricaotbsituacao { get; set; }
    }
}
