using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistance;

namespace Infrastructure.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(WorkerContext workerContext) : base(workerContext)
        {

        }
    }
}
