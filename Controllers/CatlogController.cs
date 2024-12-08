using api_3_Dependency_injection.DTOs;
using api_3_Dependency_injection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api_3_Dependency_injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatlogController : ControllerBase
    {
        private readonly shopContext db;

        // Constructor
        public CatlogController(shopContext db)
        {
            this.db = db;
        }

        // Get all items
        [HttpGet]
        public IActionResult GetAll()
        {
            var catalogList = db.catlog.ToList();
            return Ok(catalogList);
        }

        // Get item by ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var d = db.catlog.FirstOrDefault(n => n.id == id);
            if (d == null) return NotFound();

            // Object initialization fixed
            var dDTO = new displayCatalogDTO
            {
                id = d.id,
                name = d.name,
                Description = d.Description,
                productname = d.product.Select(n => n.name).ToList() // Assuming 'product' is a navigation property
            };

            return Ok(dDTO);
        }
    }
}
