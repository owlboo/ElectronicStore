using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using ElectronicStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStore.Areas.Identity.Pages.Account.Manage
{
    public class YourOrdersModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        public YourOrdersModel(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public List<OrderBills> Orders { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            var listOrderUser = await _db.Orders.Include(o => o.Customers).Where(o => o.CustomerId == userId).ToListAsync();
            Orders = listOrderUser;
            return Page();
        }
        public IActionResult Details(long? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var orderID = _db.ShipperAssignedForOrders.Where(sh => sh.OrderId == id).FirstOrDefault();
            var ID = orderID.OrderId;
            return RedirectToPage("Details","OrdersId", new {orderId = ID});
        }
    }
}