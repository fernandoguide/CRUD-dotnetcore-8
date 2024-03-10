using DotNetWebAPI_InMemoryDatabase.Data;
using DotNetWebAPI_InMemoryDatabase.dtos;
using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public class ClienteServices : ICliente
    {
        private readonly ApplicationDbContext _context;
        public ClienteServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public ClienteRequest AddCliente(ClienteRequest c)
        {
            var cliente = new Cliente
            {
                Nome = c.Nome,
                Contato = new() { Email = c.Email, Telefone = c.Telefone },
                Mensagem = new() { Mensagens = c.Mensagem }
            };

            _context.Add(cliente);
            _context.SaveChanges();
            return new ClienteRequest(
                cliente.Nome,
                cliente.Mensagem.Mensagens,
                cliente.Contato?.Telefone,
                cliente.Contato?.Email
            );
        }

    }
}
