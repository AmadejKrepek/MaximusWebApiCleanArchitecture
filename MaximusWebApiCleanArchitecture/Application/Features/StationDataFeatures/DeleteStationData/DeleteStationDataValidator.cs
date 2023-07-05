using FluentValidation;

namespace Application.Features.StationDataFeatures.DeleteStationData
{
    public sealed class DeleteStationDataValidator : AbstractValidator<DeleteStationDataRequest>
    {
        public DeleteStationDataValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
