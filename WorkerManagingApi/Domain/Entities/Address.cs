using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Address : IBaseEntity
    {
        public Address()
        {
            Users = new List<User>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
