using FluentValidation;

namespace Application.Features.StationDataFeatures.CreateStationData
{
    public sealed class CreateStationDataValidator : AbstractValidator<CreateStationDataRequest>
    {
        public CreateStationDataValidator()
        {
            RuleFor(x => x.StationId).NotEmpty().NotNull();
        }
    }
}
