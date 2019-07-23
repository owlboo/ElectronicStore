using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShoppingCartViewModel ShoppingVM { get; set; }
        [BindProperty]
        public ObjProducts objProd { get; set; }
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShoppingVM = new ShoppingCartViewModel()
            {
                Products = new List<Models.Products>(),
                Customer = new ApplicationUsers(),
                Order = new OrderBills()
            };
            objProd = new ObjProducts();
        }
        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.Name);
            if (userId == null || User == null)
            {
                return LocalRedirect("/Identity/Account/Login");
            }
            List<ObjProducts> listProducts = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            if(listProducts == null)
            {
                return View("~/Views/Shared/_NoContentError.cshtml");
            }
            if (listProducts.Count > 0)
            {
                foreach (var item in listProducts)
                {
                    Products product = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Where(p => p.Id == item.Id).FirstOrDefault();
                    ShoppingVM.Products.Add(product);
                }
            }
            return View(ShoppingVM);
        }

        public IActionResult OrderConfirm()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null || User == null)
            {
                return LocalRedirect("/Identity/Account/Login");
            }
            List<ObjProducts> listProducts = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            if (listProducts == null)
            {
                return View("~/Views/Shared/_NoContentError.cshtml");
            }
            var currentUser = _db.ApplicationUsers.Where(u => u.Id == userId).FirstOrDefault();
            ShoppingVM.Customer = currentUser;
            if (listProducts.Count > 0)
            {
                foreach (var item in listProducts)
                {
                    Products product = _db.Products.Include(p => p.Brands).Include(p => p.ProductCategory).Where(p => p.Id == item.Id).FirstOrDefault();
                    ShoppingVM.Products.Add(product);
                }
            }
            return View(ShoppingVM);
        }
        [HttpPost, ActionName("OrderConfirm")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> OrderConfirmation()
        {
            List<ObjProducts> objProducts = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);


            OrderBills order = new OrderBills()
            {
                BillName = ShoppingVM.Order.BillName,
                CreatedDate = ShoppingVM.Order.CreatedDate,
                CustomerId = Id,
                TotalPrice = ShoppingVM.Order.TotalPrice,
                ShippingFee = ShoppingVM.Order.ShippingFee,
                Status = false
            };

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            long orderId = order.Id;

            foreach (var item in objProducts)
            {
                ProductSelectedForBill productSelectedForBill = new ProductSelectedForBill()
                {
                    ProductId = item.Id,
                    OrderId = orderId,
                    ProductQuantity = item.Quantity
                };
                _db.ProductSelectedForOrders.Add(productSelectedForBill);
                var product = _db.Products.Where(p => p.Id == item.Id).FirstOrDefault();
                product.Quantity = product.Quantity - item.Quantity;
            }
            await _db.SaveChangesAsync();
            objProducts = new List<ObjProducts>();
            HttpContext.Session.Set("ssShoppingCart", objProducts);
            return RedirectToAction("Index", "Home", new { area = "Customer" });
        }
        public IActionResult Remove(long id)
        {
            if (objProd.Id != id)
            {
                return View();
            }
            List<ObjProducts> lstShoppingCart = HttpContext.Session.Get<List<ObjProducts>>("ssShoppingCart");
            foreach (var item in lstShoppingCart)
            {
                if(item.Id == objProd.Id)
                {
                    objProd.Quantity = item.Quantity;
                }
            }
            long ID = 0;
            if (lstShoppingCart.Count > 0)
            {
                foreach(var item in lstShoppingCart)
                {
                    if(item.Id == objProd.Id)
                    {
                        lstShoppingCart.Remove(item);
                        break;
                    }
                }
            }

            
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction(nameof(Index));

        }
    }
}