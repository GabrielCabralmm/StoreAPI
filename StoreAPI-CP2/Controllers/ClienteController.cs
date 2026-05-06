using AspNET.API.Data;
using Microsoft.AspNetCore.Mvc;
using StoreAPI_CP2.Entities;

namespace StoreAPI_CP2.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly ApplicationContext _context;

        public ClienteController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            try
            {
                var resultado = _context.Cliente.ToList();

                if (!resultado.Any())
                    return NoContent();

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            try
            {
                var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

                if (cliente is null)
                    return NotFound();

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddCliente(ClienteEntity model)
        {
            try
            {
                _context.Cliente.Add(model);
                _context.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult EditCliente(int id, ClienteEntity model)
        {
            try
            {
                var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

                if (cliente is null)
                    return NotFound();

                cliente.Nome = model.Nome;
                cliente.CPF = model.CPF;
                cliente.Email = model.Email;
                cliente.Telefone = model.Telefone;

                _context.Cliente.Update(cliente);
                _context.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            try
            {
                var cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

                if (cliente is null)
                    return NotFound();

                _context.Cliente.Remove(cliente);
                _context.SaveChanges();

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}