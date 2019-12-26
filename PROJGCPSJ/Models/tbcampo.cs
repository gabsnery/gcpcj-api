using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbcampo
    {
        [Key]
        public int idtbcampo { get; set; }
        public string descricaotbcampo { get; set; }
    }
}
