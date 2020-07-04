using Domain.Common;
using Domain.DTOs.Identity;
using System.Threading.Tasks;

namespace Domain.Interfaces.Identity
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> RegisterAsync(UserForRegistrationDTO userDTO);

        Task<Result> DeleteUserAsync(string userId);
    }
}
