using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElectronicStore.Areas.Identity.Pages.Account.Manage
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetOrdersId(long orderId)
        {
            ViewData["DbContext"] = _db;
            ViewData["orderId"] = orderId;
            return Page();
        }
    }
}