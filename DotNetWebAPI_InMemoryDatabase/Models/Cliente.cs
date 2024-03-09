using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWebAPI_InMemoryDatabase.Models
{
    [Table("cliente")]
    public class Cliente()
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
        [Column("fk_contato")]
        public int? ContatoId { get; set; }
        public Contato? Contato { get; set; }
    }
}