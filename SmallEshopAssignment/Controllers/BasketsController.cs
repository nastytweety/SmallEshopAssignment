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
    public class BasketsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BasketsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Baskets
        [HttpGet]
        public ActionResult<IEnumerable<Basket>> GetBaskets()
        {
            if (_unitOfWork.Baskets == null)
            {
                return NotFound();
            }
            return Ok(_unitOfWork.Baskets.GetAll());
        }

        // GET: api/Baskets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Basket>> GetBasket(int id)
        {
            if (_unitOfWork.Baskets == null)
            {
                return NotFound();
            }
            var basket = _unitOfWork.Baskets.Find(x=>x.Id == id);

            if (basket == null)
            {
                return NotFound();
            }

            return Ok(basket);
        }

        // PUT: api/Baskets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasket(int id, Basket basket)
        {
            if (id != basket.Id)
            {
                return BadRequest();
            }

            Basket dbbasket = _unitOfWork.Baskets.Get(id).Result;
            if (dbbasket == null)
            {
                return NotFound();
            }
            else
            {
                //_unitOfWork.Baskets.
            }
            return NoContent();
        }

        // POST: api/Baskets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Basket>> PostBasket(Basket basket)
        {
            _unitOfWork.Baskets.Add(basket);
            _unitOfWork.Save();

            return CreatedAtAction("GetBasket", new { id = basket.Id }, basket);
        }

        // DELETE: api/Baskets/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            if (_unitOfWork.Baskets == null)
            {
                return NotFound();
            }
            Basket basket = _unitOfWork.Baskets.Get(id).Result;
            if (basket == null)
            {
                return NotFound();
            }

            _unitOfWork.Baskets.Remove(basket);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
