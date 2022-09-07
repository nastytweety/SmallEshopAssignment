using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmallEshopAssignment.Model;
using SmallEshopAssignment.Repositories;

namespace SmallEshopAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly UnitOfWork _untiOfWork;

        public ProductsController(UnitOfWork unitOfWork)
        {
            _untiOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_untiOfWork.Products == null)
            {
                return NotFound();
            }
            return Ok(_untiOfWork.Products.GetAll());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (_untiOfWork.Products == null)
            {
                return NotFound();
            }
            var product = _untiOfWork.Products.Find(x=>x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            //_untiOfWork.Products.Entry(product).State = EntityState.Modified;

            await _untiOfWork.Save();


            return Ok();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _untiOfWork.Products.Add(product);
            await _untiOfWork.Save();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_untiOfWork.Products == null)
            {
                return NotFound();
            }
            Product product = _untiOfWork.Products.Find(x=>x.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }

            _untiOfWork.Products.Remove(product);
            await _untiOfWork.Save();

            return Ok();
        }
    }
}
