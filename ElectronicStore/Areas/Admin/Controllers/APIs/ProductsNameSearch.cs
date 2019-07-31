using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectronicStore.APIs
{
    [Route("api/[controller]")]
    public class ProductsNameSearch : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductsNameSearch(ApplicationDbContext db)
        {
            _db = db;
        }
        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var products =  _db.Products.Where(p => p.Name.Contains(term)).Select(p=>p.Name).ToList();
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpGet("Products")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var products = _db.Products.Where(p => p.Name.Contains(term)).ToList();
                return Json(products.ToString());
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}
