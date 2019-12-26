using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PROJGCPSJ.Models
{
    public partial class tbcontrato
    {
        public tbcontrato()
        {
            tbaditivo = new HashSet<tbaditivo>();
            tbarqv = new HashSet<tbarqv>();
            tbatributo = new HashSet<tbatributo>();
            tbhistrc = new HashSet<tbhistrc>();
            tbparcela = new HashSet<tbparcela>();
            tbpermissvisulzc = new HashSet<tbpermissvisulzc>();
            tbpermss = new HashSet<tbpermss>();
            tbprodutos = new HashSet<tbprodutos>();
        }
        [Key]
        public int idcontrato { get; set; }
        public string Titulocontrato { get; set; }
        public string objetocontrato { get; set; }
        public int? numerocontrato { get; set; }
        public decimal? valorpcjcontrato { get; set; }
        public decimal? valorpcjcontrapartida { get; set; }
        public int? nrprocessocontrato { get; set; }
        public DateTime? datainiciocontrato { get; set; }
        public DateTime? Datafimcontrato { get; set; }
        public int? prazocontrato { get; set; }
        public string prazotipocontrato { get; set; }
        public string tipolicitacaopcjcontrato { get; set; }
        public int? idtbarea { get; set; }
        public int? idtipodemand { get; set; }
        public int? idfontrecurs { get; set; }
        public int? idacaopap { get; set; }

        public virtual tbacaopap idacaopapNavigation { get; set; }
        public virtual tbfonterecurso idfontrecursNavigation { get; set; }
        public virtual tbarea idtbareaNavigation { get; set; }
        public virtual tbtipodemand idtipodemandNavigation { get; set; }
        public virtual ICollection<tbaditivo> tbaditivo { get; set; }
        public virtual ICollection<tbarqv> tbarqv { get; set; }
        public virtual ICollection<tbatributo> tbatributo { get; set; }
        public virtual ICollection<tbhistrc> tbhistrc { get; set; }
        public virtual ICollection<tbparcela> tbparcela { get; set; }
        public virtual ICollection<tbpermissvisulzc> tbpermissvisulzc { get; set; }
        public virtual ICollection<tbpermss> tbpermss { get; set; }
        public virtual ICollection<tbprodutos> tbprodutos { get; set; }
    }
}
