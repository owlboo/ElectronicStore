using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Models;
using ElectronicStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        [BindProperty]
        public ShipperForOrderViewModel shipperVM { get; set; }
        public OrdersController(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["DbContext"] = _db;
            var user = await _userManager.GetUserAsync(User);
            var orders = await _db.Orders.Include(o => o.Customers).Where(o => o.CustomerId == user.Id).ToListAsync();
            return View(orders);
        }
        public async Task<IActionResult> Details(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ViewData["DbContext"] = _db;
            var order = await _db.Orders.Include(o => o.Customers).Where(o => o.Id == id).FirstOrDefaultAsync();
            var Shipper = await _db.ShipperAssignedForOrders.Include(s => s.Shippers).Where(s => s.OrderId == id).FirstOrDefaultAsync();
            shipperVM = new ShipperForOrderViewModel()
            {
                ShipperAssignedForOrder = Shipper,
                Orders = order
            };
            return View(shipperVM);
        }
    }
}