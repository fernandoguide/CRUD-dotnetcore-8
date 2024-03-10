using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetWebAPI_InMemoryDatabase.Models
{
    [Table("contato")]
    public class Contato
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("telefone"), Required]
        public string Telefone { get; set; }
        [Column("email"), EmailAddress]
        public string Email { get; set; }
    }
}