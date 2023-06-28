using FluentValidation;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed class UpdateStationValidator : AbstractValidator<UpdateStationRequest>
    {
        public UpdateStationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        }
    }
}
