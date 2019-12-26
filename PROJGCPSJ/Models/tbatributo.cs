using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbatributo
    {
        [Key]
        public int idtbatributo { get; set; }
        public string valortbatributo { get; set; }
        public string datatbatributo { get; set; }
        public int tbsituacao_idtbsituacao { get; set; }
        public int tbcampo_idtbcampo { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }
        public int tbaditivo_idtbaditivo { get; set; }

        public virtual tbaditivo tbaditivo_idtbaditivoNavigation { get; set; }
        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
    }
}
