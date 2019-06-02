using System.Collections.Generic;

namespace BrandPromote.API.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public ICollection<Photo> Photos { get; set; }
        
    }
}