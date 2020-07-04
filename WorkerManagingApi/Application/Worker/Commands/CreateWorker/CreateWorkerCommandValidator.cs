using FluentValidation;
using System.Data;

namespace Application.Worker.Commands.CreateWorker
{
    public class CreateWorkerCommandValidator : AbstractValidator<CreateWorkerCommand>
    {
        public CreateWorkerCommandValidator()
        {
            RuleFor(w => w.FirstName)
                .NotEmpty();
        }
    }
}
