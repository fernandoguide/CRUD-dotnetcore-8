using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebAPI_InMemoryDatabase.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

    }
}
