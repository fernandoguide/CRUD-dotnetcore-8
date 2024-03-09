using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebAPI_InMemoryDatabase.Models;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface ICliente
    {
        public IEnumerable<Cliente> GetAllClientes();
        public void AddCliente(Cliente c);
        public void DeleteCliente(int clienteId);
        public Cliente UpdateCliente(int clienteId, Cliente c);
        public Cliente GetCliente(int clienteId);
    }
}