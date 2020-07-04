using AutoMapper;
using Domain.DTOs;
using Domain.Interfaces.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Worker.Queries.GetAllWorkers
{
    public class GetAllWorkersQuery : IRequest<List<WorkerDTO>>
    {
    }

    public class GetAllAddressHandler : IRequestHandler<GetAllWorkersQuery, List<WorkerDTO>>
    {
        private readonly IWorkerRepository _workerRepository;
        private readonly IMapper _mapper;

        public GetAllAddressHandler(IWorkerRepository workerRepository, IMapper mapper)
        {
            _workerRepository = workerRepository;
            _mapper = mapper;
        }

        public async Task<List<WorkerDTO>> Handle(GetAllWorkersQuery request, CancellationToken cancellationToken)
        {
            var workersFromDB = _workerRepository.GetAllWithIncludesQueryable();

            var workersDTO = workersFromDB.Select(x => _mapper.Map<WorkerDTO>(x)).ToList();

            return await Task.FromResult(workersDTO);
        }
    }
}
