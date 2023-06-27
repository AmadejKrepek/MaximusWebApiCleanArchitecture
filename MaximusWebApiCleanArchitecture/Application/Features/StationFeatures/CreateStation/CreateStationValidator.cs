using FluentValidation;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed class CreateStationValidator : AbstractValidator<CreateStationRequest>
    {
        public CreateStationValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
