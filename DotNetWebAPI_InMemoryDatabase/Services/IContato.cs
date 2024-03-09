using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebAPI_InMemoryDatabase.Models;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface IContato
    {
        public IEnumerable<Contato> GetAllContatos();
        public void AddContato(Contato c);
        public void DeleteContato(int contatoId);
        public Contato UpdateContato(int contatoId, Contato c);
        public Contato GetContato(int contatoId);
    }
}