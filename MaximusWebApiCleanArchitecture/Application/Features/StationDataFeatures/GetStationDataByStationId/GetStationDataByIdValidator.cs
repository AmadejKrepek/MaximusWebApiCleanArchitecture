using FluentValidation;

namespace Application.Features.StationDataFeatures.GetStationDataByStationId
{
    public sealed class GetStationDataByIdValidator : AbstractValidator<GetStationDataByStationIdRequest>
    {
        public GetStationDataByIdValidator()
        {
            RuleFor(x => x.stationId).NotEmpty();
        }
    }
}
