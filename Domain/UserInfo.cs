using System.Reflection.Metadata;

namespace Domain
{
    public class UserInfo : BaseClass
    {
        public string LastName { get; set; } 
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address? Address { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}