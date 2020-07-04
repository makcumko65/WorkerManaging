using Domain.Common;
using Domain.DTOs.Identity;
using Domain.Entities;
using Domain.Extensions.Identity;
using Domain.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;

        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task<string> GetUserNameAsync(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<(Result Result, string UserId)> RegisterAsync(UserForRegistrationDTO userDTO)
        {
            var user = new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                AddressId = userDTO.AddressId,
                Email = userDTO.Email,
                UserName = userDTO.Email
            };

            var result = await _userManager.CreateAsync(user, userDTO.Password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<Result> DeleteUserAsync(string userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        public async Task<Result> DeleteUserAsync(User user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }
    }
}
