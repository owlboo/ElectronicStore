using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Extensions;
using ElectronicStore.Helper;
using ElectronicStore.Models;
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
        //public ProductAttributesViewModel AttributeVM { get; set; }
        public DetaisViewModel DetailsVM { get; set; }
        [BindProperty]
        public ObjProducts objprod { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
            //AttributeVM = new ProductAttributesViewModel()
            //{
            //    ProductAttributes = new Models.ProductAttributes(),
            //    Products = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).ToList()
            //};
            DetailsVM = new DetaisViewModel
            {
                ProductAttributes = new Models.ProductAttributes(),
                Products = new Models.Products()
            };
            objprod = new ObjProducts();
        }
        public IActionResult Index()
        {
            var products = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Include(P=>P.ProductImages);
            return View(products.ToList());
        }
        //Details GET
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ICollection<ProductImages> Images = _db.ProductImages.Where(i => i.ProductId == id).ToList();
            DetailsVM.Products = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Include(P => P.ProductImages).Where(p => p.Id == id).FirstOrDefault();
            DetailsVM.Products.ProductImages = Images;
            if (DetailsVM.Products == null)
            {
                return NotFound();
            }
            DetailsVM.ProductAttributes = _db.ProductAttributes.Where(a => a.ProductId == id).FirstOrDefault();
            if (DetailsVM.ProductAttributes == null)
            {
                return NotFound();
            }
 
            ViewData["DbContext"] = _db;
            //var relatedProduct = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Where(p => p.Brands.Name == DetailsVM.Products.Brands.Name).ToList();
            //ViewBag.relatedProd = relatedProduct;
            List<DetaisViewModel> details = new List<DetaisViewModel>();
            details.Add(DetailsVM);
            var prodFromDb = _db.Products.Where(p => p.Id == id).FirstOrDefault();
            prodFromDb.ViewCount = prodFromDb.ViewCount + 1;
            _db.SaveChanges();
            return View(details);
        }
        //Details POST
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailPost(long id)
        {
            objprod.Id = id;
            objprod.Quantity = DetailsVM.Quantity;
            List<ObjProducts> list_products = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            if (list_products == null)
            {
                list_products = new List<ObjProducts>();
            }
            list_products.Add(objprod);
            HttpContext.Session.Set("ssShoppingCart", list_products);
            return RedirectToAction("Index","Home",new { area = "Customer" });
        }

        public IActionResult Remove(long id)
        {
            if(objprod.Id != id)
            {
                return View();
            }
            List<ObjProducts> lstShoppingCart = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            if (lstShoppingCart.Count > 0)
            {
                if (lstShoppingCart.FirstOrDefault().Id.Equals(objprod.Id))
                {
                    lstShoppingCart.Remove(objprod);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction(nameof(Index));

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}