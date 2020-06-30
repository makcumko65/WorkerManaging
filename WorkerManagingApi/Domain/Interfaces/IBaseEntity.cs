using System;

namespace Domain.Interfaces
{
    public interface IBaseEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

    }
}
