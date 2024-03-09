using DotNetWebAPI_InMemoryDatabase.Models;
using DotNetWebAPI_InMemoryDatabase.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContato _contatos;
        public ContatosController(IContato contatos)
        {
            _contatos = contatos;
        }
        [HttpGet]
        public IActionResult GetAllContatos()
        {
            IEnumerable<Contato> contatos = _contatos.GetAllContatos();
            return Ok(contatos);
        }
        [HttpPost]
        public IActionResult AddContato(Contato c)
        {
            _contatos.AddContato(c);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteContato(int id)
        {
            if (_contatos.GetContato(id) == null)
            {
                return NoContent();
            }
            _contatos.DeleteContato(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutContato(int id, Contato c)
        {
            if (ModelState.IsValid)
            {
                Contato contatoResponse = _contatos.UpdateContato(id, c);
                return Ok(contatoResponse);
            }
            return BadRequest();
        }
        [HttpGet("{id}")]
        public IActionResult GetContato(int id)
        {
            Contato c = _contatos.GetContato(id);
            return Ok(c);
        }
    }
}
