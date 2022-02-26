using System.ComponentModel.DataAnnotations;

namespace Inventory_Order_Managemen.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
