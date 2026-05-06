using AspNET.API.Data;
using Microsoft.AspNetCore.Mvc;
using StoreAPI_CP2.Entities;

namespace StoreAPI_CP2.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ProdutoController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _context.Produto.ToList();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = _context.Produto.Find(id);

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Create(ProdutoEntity produto)
        {
            if (produto == null)
                return BadRequest();

            _context.Produto.Add(produto);
            _context.SaveChanges();

            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProdutoEntity produto)
        {
            var produtoExistente = _context.Produto.Find(id);

            if (produtoExistente == null)
                return NotFound();

            if (produto == null)
                return BadRequest();

            produtoExistente.Produto = produto.Produto;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _context.Produto.Find(id);

            if (produto == null)
                return NotFound();

            _context.Produto.Remove(produto);
            _context.SaveChanges();

            return NoContent();
        }
    }
}