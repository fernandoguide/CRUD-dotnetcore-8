using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebAPI_InMemoryDatabase.Models;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public interface IMensagem
    {
        public IEnumerable<Mensagem> GetAllMensagens();
        public void AddMensagem(Mensagem m);
        public void DeleteMensagem(int mensagemId);
        public Mensagem UpdateMensagem(int mensagemId, Mensagem m);
        public Mensagem GetMensagem(int mensagemId);
    }
}