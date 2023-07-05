using FluentValidation;

namespace Application.Features.StationDataFeatures.UpdateStationData
{
    public sealed class UpdateStationDataValidator : AbstractValidator<UpdateStationDataRequest>
    {
        public UpdateStationDataValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.StationId).NotEmpty();
        }
    }
}
