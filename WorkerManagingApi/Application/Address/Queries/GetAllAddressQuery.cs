using Domain.DTOs;
using Domain.Interfaces.Repositories;
using MediatR;
using System.Collections.Generic;
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

        public GetAllAddressHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressDTO>> Handle(GetAllAddressQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetListAsync();

            var resultAdresses = new List<AddressDTO>();
            
            foreach(var address in addresses)
            {
                resultAdresses.Add(new AddressDTO
                {
                    Id = address.Id,
                    Name = address.Name
                });
            }

            return resultAdresses;
        }
    }
}
