using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Common.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<List<Address>, List<AddressDTO>>().ReverseMap();
        }
    }
}
