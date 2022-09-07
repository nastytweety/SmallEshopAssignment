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
    public class ServicesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public ServicesController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Services
        [HttpGet]
        public ActionResult<IEnumerable<Service>> GetServices()
        {
            if (_unitOfWork.Services == null)
            {
                return NotFound();
            }
            return Ok(_unitOfWork.Services.GetAll());
        }

        // GET: api/Services/5
        [HttpGet("{id}")]
        public ActionResult<Service> GetService(int id)
        {
            if (_unitOfWork.Services == null)
            {
                return NotFound();
            }
            Service service = _unitOfWork.Services.Find(x=>x.Id == id).FirstOrDefault();

            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        // PUT: api/Services/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutService(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(service).State = EntityState.Modified;


            await _unitOfWork.Save();

            return NoContent();
        }

        // POST: api/Services
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Service>> PostService(Service service)
        {
            _unitOfWork.Services.Add(service);
            await _unitOfWork.Save();

            return CreatedAtAction("GetService", new { id = service.Id }, service);
        }

        // DELETE: api/Services/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            if (_unitOfWork.Services == null)
            {
                return NotFound();
            }
            Service service = _unitOfWork.Services.Find(x => x.Id == id).SingleOrDefault();
            if (service == null)
            {
                return NotFound();
            }

            _unitOfWork.Services.Remove(service);
            await _unitOfWork.Save();

            return Ok();
        }

    }
}
