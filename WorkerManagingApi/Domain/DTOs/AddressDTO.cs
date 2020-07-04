using Domain.Common.Mapper;
using Domain.Entities;
using System;

namespace Domain.DTOs
{
    public class AddressDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
