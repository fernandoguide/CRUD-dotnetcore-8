using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWebAPI_InMemoryDatabase.dtos
{
    public record ContatoRequest(string telefonePessoal, string emailCorporativo);

}