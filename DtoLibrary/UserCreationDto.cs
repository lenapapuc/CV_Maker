using System.Net;

namespace DtoLibrary
{
    public class UserCreationDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}