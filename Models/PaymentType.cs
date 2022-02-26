
using System.ComponentModel.DataAnnotations;

namespace Inventory_Order_Managemen.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        [Required]
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
