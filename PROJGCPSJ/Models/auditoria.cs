using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJGCPSJ.Models
{
    public partial class auditoria
    {
        [Key]
        public int idauditoria { get; set; }
        public DateTime? horaauditoria { get; set; }
        public string usuarioauditoria { get; set; }
        public string tabelaauditoria { get; set; }
        public int? id_registroauditoria { get; set; }
        public string valoranterior { get; set; }
        public string valornovoauditoria { get; set; }
    }
}
