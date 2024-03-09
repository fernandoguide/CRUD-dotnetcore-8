using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DotNetWebAPI_InMemoryDatabase.Models
{
    [Table("mensagens")]
    public class Mensagem
    {
        [Key]
        [Column("id_mensagem")]
        public int IdMensagem { get; set; }

        [Column("mensagem")]
        public string mensagens { get; set; }

        [Column("data_hora", TypeName = "datetime"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
        public DateTime DataHora { get; set; }
        [Column("fk_cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}