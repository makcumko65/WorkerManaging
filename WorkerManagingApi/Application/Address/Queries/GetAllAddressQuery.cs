using AutoMapper;
using Domain.DTOs;
using Domain.Interfaces.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Address.Queries
{
    public class GetAllAddressQuery : IRequest<List<AddressDTO>>
    {
    }

    public class GetAllAddressHandler : IRequestHandler<GetAllAddressQuery, List<AddressDTO>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAllAddressHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<List<AddressDTO>> Handle(GetAllAddressQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetListAsync();

            var resultAdresses = addresses.Select(x => _mapper.Map<AddressDTO>(x))
                                          .ToList();

            return resultAdresses;
        }
    }
}
