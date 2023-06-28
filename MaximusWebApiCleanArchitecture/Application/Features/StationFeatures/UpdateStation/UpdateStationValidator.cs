using FluentValidation;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed class UpdateStationValidator : AbstractValidator<UpdateStationRequest>
    {
        public UpdateStationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Latitude).NotNull();
            RuleFor(x => x.Longitude).NotNull();
            RuleFor(x => x.Altitude).NotEmpty().NotNull();
            RuleFor(x => x.ConnectionStatus).NotNull();
            RuleFor(x => x.LastUpdated).NotNull();
            RuleFor(x => x.UnitOfMeasurement).NotNull();
        }
    }
}
