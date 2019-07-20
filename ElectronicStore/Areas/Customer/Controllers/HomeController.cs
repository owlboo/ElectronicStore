using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ProductAttributesViewModel AttributeVM { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
            AttributeVM = new ProductAttributesViewModel()
            {
                ProductAttributes = new Models.ProductAttributes(),
                Products = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).ToList()
            };
        }
        public IActionResult Index()
        {
            var products = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory);
            return View(products.ToList());
        }
        //Details GET
        public async Task<IActionResult> Details(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            AttributeVM.Products =  _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Where(p => p.Id == id);
            if (AttributeVM.Products == null)
            {
                return NotFound();
            }
            return View(AttributeVM);
        }
    }
}