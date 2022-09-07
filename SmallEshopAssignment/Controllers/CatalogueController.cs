using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmallEshopAssignment.Model;
using SmallEshopAssignment.Repositories;
using SmallEshopAssignment.Services;
using System.Collections.Generic;

namespace SmallEshopAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        ICatalogueService _catalogueService;

        public CatalogueController(UnitOfWork unitOfWork, ICatalogueService catalogueService)
        {
            _unitOfWork = unitOfWork;
            _catalogueService = catalogueService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts([FromQuery] string? brand, [FromQuery] double? LowPrice, [FromQuery] double? HighPrice, [FromQuery] int? Page)
        {
            List<Product> productList = _catalogueService.GetProducts().ToList();
            if(brand == null && LowPrice == null && HighPrice == null)
            {
                return Ok(productList);
            }
            else if(LowPrice == null && HighPrice == null)
            {
                return Ok(productList.Find(x => x.Brand == brand));
            }
            else if(LowPrice == null)
            {
                return Ok(productList.Find(x => x.Brand == brand && x.Price<=HighPrice));
            }
            else if(HighPrice == null)
            {
                return Ok(productList.Find(x => x.Brand == brand && x.Price >= LowPrice));
            }
            else
            {
                return Ok(productList.Find(x => x.Brand == brand
                                                    && x.Price >= LowPrice
                                                    && x.Price <= HighPrice));
            }    
        }
    }
}
