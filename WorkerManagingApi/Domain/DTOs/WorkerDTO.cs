using Domain.DTOs.Identity;
using System.Collections.Generic;

namespace Domain.DTOs
{
    public class WorkerDTO
    {
        public WorkerDTO()
        {
            Categories = new List<CategoryDTO>();
        }

        public string Description { get; set; }

        public UserDTO User { get; set; }

        public string UserId { get; set; }

        public IList<CategoryDTO> Categories { get; set; }
    }
}
