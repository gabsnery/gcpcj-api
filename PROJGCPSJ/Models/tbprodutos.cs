using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbprodutos
    {
        [Key]
        public int idtbprodutos { get; set; }
        public string descricaotbprodutos { get; set; }
        public string linktbprodutos { get; set; }
        public string tipotbprodutos { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }
        public int tbaditivo_idtbaditivo { get; set; }
        public int tbarqv_idtbarqv { get; set; }
        public int tbhistrc_idhistrc { get; set; }
        public int tbparcela_idtbparcela { get; set; }

        public virtual tbaditivo tbaditivo_idtbaditivoNavigation { get; set; }
        public virtual tbarqv tbarqv_idtbarqvNavigation { get; set; }
        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
        public virtual tbhistrc tbhistrc_idhistrcNavigation { get; set; }
        public virtual tbparcela tbparcela_idtbparcelaNavigation { get; set; }
    }
}
