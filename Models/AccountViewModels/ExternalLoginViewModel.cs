using System.ComponentModel.DataAnnotations;

namespace Inventory_Order_Managemen.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
