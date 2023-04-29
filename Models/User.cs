using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class User
    {   
        public int UserId {get; set;}
        [BindProperty]
        [Display(Name = "First Name:")]
        [Required]
        public string FirstName {get; set;} = string.Empty;
        [Display(Name = "Last Name:")]
        [Required]
        public string LastName {get; set;} = string.Empty;
        [Display(Name = "Biography:")]
        public string Biography {get; set;} = string.Empty;
        [BindProperty]
        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email {get; set;} = string.Empty;
        public List<UserBook> UserBooks {get; set;} = default!;
    }
}