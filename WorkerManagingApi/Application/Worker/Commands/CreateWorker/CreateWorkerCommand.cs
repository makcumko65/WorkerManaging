using Domain.DTOs.Identity;
using Domain.Interfaces.Identity;
using Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Worker.Commands.CreateWorker
{
    public class CreateWorkerCommand : IRequest<string>
    {
        public string Description { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid AddressId { get; set; }
    }

    public class CreateWorkerCommandHandler : IRequestHandler<CreateWorkerCommand, string>
    {
        private readonly IIdentityService _identityService;
        private readonly IWorkerRepository _workerRepository;

        public CreateWorkerCommandHandler(IIdentityService identityService, IWorkerRepository workerRepository)
        {
            _identityService = identityService;
            _workerRepository = workerRepository;
        }

        public async Task<string> Handle(CreateWorkerCommand request, CancellationToken cancellationToken)
        {
            var user = new UserForRegistrationDTO
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                AddressId = request.AddressId,
                Email = request.Email,
                Password = request.Password
            };

            var (Result, UserId) = await _identityService.RegisterAsync(user);

            if (Result.Succeeded)
            {
                var worker = new Domain.Entities.Worker
                {
                    UserId = UserId,
                    Description = request.Description
                };

                _workerRepository.Add(worker);
                await _workerRepository.SaveChangesAsync();

                return worker.UserId;
            }

            throw new Exception(Result.Errors.First());
        } 
    }
}
