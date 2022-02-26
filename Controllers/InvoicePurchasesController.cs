using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Order_Managemen.Data;
using Inventory_Order_Managemen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Order_Managemen.Controllers
{
    [Authorize(Roles = Pages.MainMenu.PurchaseOrder.RoleName)]
    public class InvoicePurchasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoicePurchasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult InvoicePurchases(int id)
        {
            PurchaseOrder purchaseOrder = _context.PurchaseOrder.SingleOrDefault(x => x.PurchaseOrderId.Equals(id));

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }
    }
}