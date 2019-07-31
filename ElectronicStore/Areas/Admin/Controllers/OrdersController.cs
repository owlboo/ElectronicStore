using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Models;
using ElectronicStore.Models.ViewModels;
using ElectronicStore.Ultilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShipperForOrderViewModel shipperVM { get; set; }
        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        
        }
        public IActionResult Index()
        {
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s=>s.Shippers).Include(o=>o.Orders).Where(sh=>sh.ShipperId == null).ToList());
        }

        public IActionResult Pending()
        {
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId !=null).ToList());
        }
        public IActionResult Successful()
        {
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId != null).ToList());
        }
        [HttpGet]
        public IActionResult Assign(int? id)
        {
            if(id ==null)
            {
                return NotFound();
            }
            ViewData["DbContext"] = _db;
            var orderId = _db.ShipperAssignedForOrders.Find(id).OrderId;
            var orderFromDb = _db.Orders.Include(o => o.Customers).Where(o => o.Id == orderId).FirstOrDefault();
            shipperVM = new ShipperForOrderViewModel()
            {
                Orders = orderFromDb
            };
            return View(shipperVM);
        }
        [HttpPost, ActionName("Assign")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignPost(int id)
        {
            var orderNotAssignedFromDb = _db.ShipperAssignedForOrders.Find(id);
            var shipperID = shipperVM.ShipperAssignedForOrder.ShipperId;
            orderNotAssignedFromDb.ShipperId = shipperID;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Pending));
        }
        [HttpGet]
        public IActionResult Confirm(long? id)
        {
            if(id == null)
            { return NotFound(); }
            var orderFromDb = _db.Orders.Where(o => o.Id == id).FirstOrDefault();
            if (orderFromDb == null)
            {
                return NotFound();
            }
            orderFromDb.Status = true;
             _db.SaveChanges();
            return RedirectToAction(nameof(Successful));
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            ViewData["DbContext"] = _db;
            if(id == null)
            {
                return NotFound();
            }
             var shFromDb = _db.ShipperAssignedForOrders.Include(sh => sh.Orders).Include(sh => sh.Shippers).FirstOrDefault();
            var orderID = _db.ShipperAssignedForOrders.Find(id).OrderId;
            var ordersFromDb = _db.Orders.Include(o => o.Customers).Where(o => o.Id == orderID).FirstOrDefault();
            if(shFromDb == null)
            {
                return NotFound();
            }
            shipperVM = new ShipperForOrderViewModel()
            {
                ShipperAssignedForOrder = shFromDb,
                Orders = ordersFromDb
            };
            return View(shipperVM);
        }
    }
}