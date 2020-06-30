using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Worker : IBaseEntity
    {
        public Worker()
        {
            Categories = new List<WorkerCategory>();
        }
        public string Description { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public IList<WorkerCategory> Categories { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
