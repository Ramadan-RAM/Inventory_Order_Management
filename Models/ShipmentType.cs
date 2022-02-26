

using System.ComponentModel.DataAnnotations;

namespace Inventory_Order_Managemen.Models
{
    public class ShipmentType
    {
        public int ShipmentTypeId { get; set; }
        [Required]
        public string ShipmentTypeName { get; set; }
        public string Description { get; set; }
    }
}
