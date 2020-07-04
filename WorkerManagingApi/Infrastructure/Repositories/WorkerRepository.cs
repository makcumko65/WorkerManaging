using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistance;

namespace Infrastructure.Repositories
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(WorkerContext workerContext) : base(workerContext)
        {

        }
    }
}
