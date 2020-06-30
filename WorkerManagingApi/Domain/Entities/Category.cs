using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Category : IBaseEntity
    {
        public Category()
        {
            Workers = new List<WorkerCategory>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<WorkerCategory> Workers { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
