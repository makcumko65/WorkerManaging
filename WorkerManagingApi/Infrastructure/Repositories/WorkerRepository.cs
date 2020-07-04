using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(WorkerContext workerContext) : base(workerContext)
        {

        }

        public IQueryable<Worker> GetAllWithIncludesQueryable()
        {
            var workers = ModelDbSets.Include(w => w.User)
                                        .ThenInclude(u => u.Adrress)
                                     .Include(x => x.Categories)
                                        .ThenInclude(x => x.Category).AsQueryable();

            return workers;
        }
    }
}
