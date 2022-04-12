using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class ExternalLoginConfirmationViewModelModel 
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
