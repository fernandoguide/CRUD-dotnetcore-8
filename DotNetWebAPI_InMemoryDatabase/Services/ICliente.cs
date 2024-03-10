using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebAPI_InMemoryDatabase.dtos;
using DotNetWebAPI_InMemoryDatabase.Models;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface ICliente
    {
        public ClienteRequest AddCliente(ClienteRequest c);
    }
}