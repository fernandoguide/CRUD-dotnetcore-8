using DotNetWebAPI_InMemoryDatabase.dtos;
using DotNetWebAPI_InMemoryDatabase.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ICliente _clientes;
        public ClientesController(ICliente clientes)
        {
            _clientes = clientes;
        }

        [EnableCors]
        [HttpPost]
        public IActionResult AddContato(ClienteRequest c)
        {
            var result = _clientes.AddCliente(c);
            return Ok(result);
        }

    }
}
