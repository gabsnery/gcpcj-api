using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbarqv
    {
        public tbarqv()
        {
            tbprodutos = new HashSet<tbprodutos>();
        }
        [Key]
        public int idarqvs { get; set; }
        public string descricaoarqvs { get; set; }
        public string linkarqvs { get; set; }
        public string tipoarqvs { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }
        public int tbaditivo_idtbaditivo { get; set; }
        public int idtbpessoa { get; set; }
        public int tbhistrc_idhistrc { get; set; }
        public int tbparcela_idtbparcela { get; set; }

        public virtual tbpessoa idtbpessoaNavigation { get; set; }
        public virtual tbaditivo tbaditivo_idtbaditivoNavigation { get; set; }
        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
        public virtual tbhistrc tbhistrc_idhistrcNavigation { get; set; }
        public virtual tbparcela tbparcela_idtbparcelaNavigation { get; set; }
        public virtual ICollection<tbprodutos> tbprodutos { get; set; }
    }
}
