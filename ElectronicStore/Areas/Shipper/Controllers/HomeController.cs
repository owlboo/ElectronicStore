using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Areas.Shipper.Controllers
{
    [Area("Shipper")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShipperForOrderViewModel shipperVM { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ID = _db.ApplicationUsers.Find(userID).Id;
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId ==ID).ToList());
        }
        
        public IActionResult IncompletedTask()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ID = _db.ApplicationUsers.Find(userID).Id;
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId == ID).ToList());
        }
        public IActionResult PendingTask()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ID = _db.ApplicationUsers.Find(userID).Id;
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId == ID).ToList());
        }
        public IActionResult CompletedTask()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ID = _db.ApplicationUsers.Find(userID).Id;
            ViewData["DbContext"] = _db;
            return View(_db.ShipperAssignedForOrders.Include(s => s.Shippers).Include(o => o.Orders).Where(sh => sh.ShipperId == ID).ToList());
        }
        [HttpGet]
        public IActionResult ShipperConfirm(long? id)
        {
            if(id ==null)
            {
                return NotFound();
            }
            var orderFromDb = _db.Orders.Where(o => o.Id == id).FirstOrDefault();
            if(orderFromDb == null)
            {
                return NotFound();
            }
            orderFromDb.ShipperConfirm = true;
            _db.SaveChanges();
            return RedirectToAction(nameof(CompletedTask));
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            ViewData["DbContext"] = _db;
            if (id == null)
            {
                return NotFound();
            }
            var shFromDb = _db.ShipperAssignedForOrders.Include(sh => sh.Orders).Include(sh => sh.Shippers).FirstOrDefault();
            var orderID = _db.ShipperAssignedForOrders.Find(id).OrderId;
            var ordersFromDb = _db.Orders.Include(o => o.Customers).Where(o => o.Id == orderID).FirstOrDefault();
            if (shFromDb == null)
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