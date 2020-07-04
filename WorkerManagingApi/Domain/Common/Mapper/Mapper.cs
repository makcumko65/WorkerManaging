using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.Identity;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Common.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Worker, WorkerDTO>()
                .ForMember(w => w.Categories, wc => wc.MapFrom(c => c.Categories.Select(w => w.Category)));

            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
