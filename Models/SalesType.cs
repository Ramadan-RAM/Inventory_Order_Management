
using System.ComponentModel.DataAnnotations;

namespace Inventory_Order_Managemen.Models
{
    public class SalesType
    {
        public int SalesTypeId { get; set; }
        [Required]
        public string SalesTypeName { get; set; }
        public string Description { get; set; }
    }
}
