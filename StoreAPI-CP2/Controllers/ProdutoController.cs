using AspNET.API.Data;
using Microsoft.AspNetCore.Mvc;
using StoreAPI_CP2.Entities;

namespace StoreAPI_CP2.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : Controller
    {

        private readonly ApplicationContext _context;

        public ProdutoController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProdutos()
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
        public IActionResult GetProduto(int id)
        {
            try
            {
                var produto = _context.Produto.FirstOrDefault(x => x.Id == id);

                if (produto is null)
                    return NotFound();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddProduto(ProdutoEntity model)
        {
            try
            {
                _context.Produto.Add(model);
                _context.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult EditProduto(int id, ProdutoEntity model)
        {
            try
            {
                var produto = _context.Produto.FirstOrDefault(x => x.Id == id);

                if (produto is null)
                    return NotFound();

                produto.Produto = model.Produto;
                produto.Categoria = model.Categoria;
                produto.Preco = model.Preco;
                produto.QtdEstoque = model.QtdEstoque;

                _context.Produto.Update(produto);
                _context.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            try
            {
                var produto = _context.Produto.FirstOrDefault(x => x.Id == id);

                if (produto is null)
                    return NotFound();

                _context.Produto.Remove(produto);
                _context.SaveChanges();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
