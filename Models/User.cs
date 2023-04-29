using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Biography {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public List<UserBook> UserBooks {get; set;} = default!;
    }
}