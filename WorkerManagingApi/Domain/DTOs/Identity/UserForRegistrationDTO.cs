using System;

namespace Domain.DTOs.Identity
{
    public class UserForRegistrationDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid AddressId { get; set; }
    }
}
