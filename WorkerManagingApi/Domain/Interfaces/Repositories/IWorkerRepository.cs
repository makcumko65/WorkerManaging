using Domain.Entities;
using System.Linq;

namespace Domain.Interfaces.Repositories
{
    public interface IWorkerRepository : IRepository<Worker>
    {
        IQueryable<Worker> GetAllWithIncludesQueryable();
    }
}
