using AspNET.API.Data;
using Microsoft.AspNetCore.Mvc;
using StoreAPI_CP2.Entities;

namespace StoreAPI_CP2.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClienteController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _context.Cliente.ToList();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Create(ClienteEntity cliente)
        {
            if (cliente == null)
                return BadRequest();

            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ClienteEntity cliente)
        {
            var clienteExistente = _context.Cliente.Find(id);

            if (clienteExistente == null)
                return NotFound();

            if (cliente == null)
                return BadRequest();

            clienteExistente.Nome = cliente.Nome;
            clienteExistente.Email = cliente.Email;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
                return NotFound();

            _context.Cliente.Remove(cliente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}