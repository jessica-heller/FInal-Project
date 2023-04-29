using System.ComponentModel.DataAnnotations;
namespace FinalProject.Models
{
    public class Book
    {
        public int BookId {get; set;}
        [Required]
        [Display(Name = "Book Title:")]
        public string Title {get; set;} = string.Empty;
        [Required]
        [Display(Name = "Author:")]
        [StringLength(30)]
        public string Author {get; set;} = string.Empty;
        [Required]
        [Display(Name = "Publisher:")]
        [StringLength(60)]
        public string Publisher {get; set;} = string.Empty;
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date:")]
        public DateOnly PublicationDate {get; set;} 
        
        [Display(Name = "ISBN: ")]
        public string ISBN {get; set;} = string.Empty;
        [Required]
        [StringLength(30)]
        [Display(Name = "Genre:")]
        public string Genre {get; set;} = string.Empty;
        [Display(Name = "Book Description:")]
        public string BookDescription {get; set;} = string.Empty;
        public List<UserBook> UserBooks {get; set;} = default!;
    }

    public class UserBook
    {
        public int BookId {get; set;}
        public int UserId {get; set;}
        public User User {get; set;} = default!;
        public Book Book {get; set;} = default!;
    }
}