using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventory_Order_Managemen.Data;
using Inventory_Order_Managemen.Models;
using Microsoft.AspNetCore.Authorization;

namespace Inventory_Order_Managemen.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/InvoicePurchases")]
    public class InvoicePurchasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoicePurchasesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            PurchaseOrder result = await _context.PurchaseOrder
                .Where(x => x.PurchaseOrderId.Equals(id))
                .Include(x => x.PurchaseOrderLines)
                .FirstOrDefaultAsync();

            return Ok(result);
        }
    }
}
