using Application.Features.StationFeatures.GetStationById;
using FluentValidation;

namespace Application.Features.StationFeatures.GetStationByName
{
    public sealed class GetStationByNameValidator : AbstractValidator<GetStationByNameRequest>
    {
        public GetStationByNameValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }
}
