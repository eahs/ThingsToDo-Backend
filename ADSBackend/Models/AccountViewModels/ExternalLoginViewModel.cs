using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
