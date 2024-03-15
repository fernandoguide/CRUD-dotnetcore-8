using DotNetWebAPI_InMemoryDatabase.Data;
using DotNetWebAPI_InMemoryDatabase.Models;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public class ContatoServices : IContato
    {
        private readonly ApplicationDbContext _context;
        public ContatoServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddContato(Contato c)
        {
            _context.Contatos.Add(c);
            _context.SaveChanges();
        }
        public void DeleteContato(int contatoId)
        {
            var c = _context.Contatos.FirstOrDefault(x => x.Id == contatoId);
            if (c != null)
            {
                _context.Contatos.Remove(c);
                _context.SaveChanges();
            }
        }
        public IEnumerable<Contato> GetAllContatos()
        {
            IEnumerable<Contato> contatos = _context.Contatos;
            return contatos;
        }
        public Contato GetContato(int contatoId)
        {
            Contato c = _context.Contatos.FirstOrDefault(c => c.Id == contatoId);
            return c;
        }

        public Contato UpdateContato(int contatoId, Contato c)
        {
            var contatoDB = GetContato(contatoId);
            if (c.Email != null)
            {
                contatoDB.Email = c.Email;
            }
            if (c.Telefone != null)
            {
                contatoDB.Telefone = c.Telefone;
            }
            var entityEntry = _context.Update(contatoDB);
            _context.SaveChanges(true);
            return entityEntry.Entity;
        }
    }
}
