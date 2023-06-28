using FluentValidation;

namespace Application.Features.StationFeatures.DeleteStation
{
    public sealed class DeleteStationValidator : AbstractValidator<DeleteStationRequest>
    {
        public DeleteStationValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
        }
    }
}
