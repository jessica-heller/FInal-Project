namespace FinalProject.Models
{
    public class Book
    {
        public int BookId {get; set;}
        public string Title {get; set;} = string.Empty;
        public string Author {get; set;} = string.Empty;
        public string Publisher {get; set;} = string.Empty;
        public DateOnly PublicationDate {get; set;} 
        public string ISBN {get; set;}
        public string Genre {get; set;} = string.Empty;
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