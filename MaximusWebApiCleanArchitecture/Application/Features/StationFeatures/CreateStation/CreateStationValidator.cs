using FluentValidation;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed class CreateStationValidator : AbstractValidator<CreateStationRequest>
    {
        public CreateStationValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Latitude).NotNull();
            RuleFor(x => x.Longitude).NotNull();
            RuleFor(x => x.Altitude).NotEmpty().NotNull();
            RuleFor(x => x.ConnectionStatus).NotNull();
            RuleFor(x => x.LastUpdated).NotNull();
            RuleFor(x => x.UnitOfMeasurement).NotNull();
        }
    }
}
