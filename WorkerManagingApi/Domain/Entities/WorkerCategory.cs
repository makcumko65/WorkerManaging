using System;

namespace Domain.Entities
{
    public class WorkerCategory
    {
        public Worker Worker { get; set; }
        public string WorkerId { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
