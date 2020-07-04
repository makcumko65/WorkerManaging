using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs.Identity
{
    public class UserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid AddressId { get; set; }

        public AddressDTO Adrress { get; set; }
    }
}
