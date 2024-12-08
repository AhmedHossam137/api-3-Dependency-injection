using api_3_Dependency_injection.DTOs;
using api_3_Dependency_injection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_3_Dependency_injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        // learnContext db = new learnContext();
        shopContext db;
        public productController(shopContext db)
        {
            this.db = db;
        }


        [HttpGet]
        public IActionResult getall()
        {
            List<product> sts = db.product.ToList();
            List<productDTO> stsDTO = new List<productDTO>();
            foreach (product s in sts)
            {

                productDTO stDTO = new productDTO()
                {
                    id = s.id,
                    name = s.name,
                    price = s.price,
                    CatlogID = s.CatlogID,
                };
                stsDTO.Add(stDTO);

            }



            return Ok(stsDTO);
        }
        [HttpGet("{id}")]
        public IActionResult getbyid(int id)
        {
            product s = db.product.Where(n => n.id == id).FirstOrDefault();
            if (s == null) return NotFound();
            else
            {
                productDTO sdto = new productDTO()
                {
                    id = s.id,
                    name = s.name,
                    price = s.price,
                    CatlogID = s.CatlogID,
                };


                return Ok(sdto);

            }




        }
    }
}
