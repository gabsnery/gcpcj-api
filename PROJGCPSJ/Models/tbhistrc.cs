using System; using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PROJGCPSJ.Models
{
    public partial class tbhistrc
    {
        public tbhistrc()
        {
            tbarqv = new HashSet<tbarqv>();
            tbprodutos = new HashSet<tbprodutos>();
        }
        [Key]
        public int idhistrc { get; set; }
        public DateTime datainclshistrc { get; set; }
        public string textohistrc { get; set; }
        public string tipohistrc { get; set; }
        public int? idtbaditivo { get; set; }
        public int? idcontrato { get; set; }
        public int? idpessrespnsvl { get; set; }

        public virtual tbcontrato idcontratoNavigation { get; set; }
        public virtual tbpessoa idpessrespnsvlNavigation { get; set; }
        public virtual tbaditivo idtbaditivoNavigation { get; set; }
        public virtual ICollection<tbarqv> tbarqv { get; set; }
        public virtual ICollection<tbprodutos> tbprodutos { get; set; }
    }
}
