using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbparcela
    {
        public tbparcela()
        {
            tbarqv = new HashSet<tbarqv>();
            tbprodutos = new HashSet<tbprodutos>();
        }
        [Key]
        public int idtbparcela { get; set; }
        public decimal? valortbparcela { get; set; }
        public int? descricaotbparcela { get; set; }
        public bool? liberadatbparcela { get; set; }
        public bool? pagatbparcela { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }
        public int? tbaditivo_idtbaditivo { get; set; }

        public virtual tbaditivo tbaditivo_idtbaditivoNavigation { get; set; }
        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
        public virtual ICollection<tbarqv> tbarqv { get; set; }
        public virtual ICollection<tbprodutos> tbprodutos { get; set; }
    }
}
