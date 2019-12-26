using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class tbaditivo
    {
        public tbaditivo()
        {
            tbarqv = new HashSet<tbarqv>();
            tbatributo = new HashSet<tbatributo>();
            tbhistrc = new HashSet<tbhistrc>();
            tbparcela = new HashSet<tbparcela>();
            tbprodutos = new HashSet<tbprodutos>();
        }
        [Key]
        public int idtbaditivo { get; set; }
        public decimal? valortbaditivo { get; set; }
        public string diasmesestbaditivo { get; set; }
        public int? prazotbaditivo { get; set; }
        public string motivotbaditivo { get; set; }
        public int tbcontrato_idtbcontrato { get; set; }
        public int tbacaopap_idtbacaopap { get; set; }
        public int tbfonterecurso_idtbfonterecurso { get; set; }

        public virtual tbacaopap tbacaopap_idtbacaopapNavigation { get; set; }
        public virtual tbcontrato tbcontrato_idtbcontratoNavigation { get; set; }
        public virtual tbfonterecurso tbfonterecurso_idtbfonterecursoNavigation { get; set; }
        public virtual ICollection<tbarqv> tbarqv { get; set; }
        public virtual ICollection<tbatributo> tbatributo { get; set; }
        public virtual ICollection<tbhistrc> tbhistrc { get; set; }
        public virtual ICollection<tbparcela> tbparcela { get; set; }
        public virtual ICollection<tbprodutos> tbprodutos { get; set; }
    }
}
