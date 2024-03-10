using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWebAPI_InMemoryDatabase.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Column("nome"), Required]
        public string Nome { get; set; }
        [Column("fk_contato")]
        public int ContatoId { get; set; }
        public required Contato Contato { get; set; }
        [Column("fk_mensagem")]
        public int MensagemId { get; set; }
        public required Mensagem Mensagem { get; set; }
    }
}