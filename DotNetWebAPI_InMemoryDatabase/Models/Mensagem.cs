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

        [Column("mensagem"), Required]
        public string Mensagens { get; set; }

        [Column("data_hora")]
        public DateTime DataHora { get; set; }

        public Mensagem()
        {
            DataHora = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "E. South America Standard Time");
        }
    }
}
