using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class ForgotPasswordViewModelModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
