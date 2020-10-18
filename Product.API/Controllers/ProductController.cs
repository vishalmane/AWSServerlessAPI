using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<string>>> Get()
        {
            var products = await Products.AllProducts();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Add(string name)
        {
            var total= await Products.Add(name);
            return Ok(total);
        }
    }
}