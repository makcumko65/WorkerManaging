using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;

namespace Domain.Entities
{
    public class User : IdentityUser, IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Adrress { get; set; }
        public Guid AddressId { get; set; }
        public Worker Worker { get; set; }
        public Guid WorkerId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
