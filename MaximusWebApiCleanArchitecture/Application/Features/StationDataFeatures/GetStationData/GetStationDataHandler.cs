using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.StationDataFeatures.GetStationData
{
    public sealed class GetStationDataHandler : IRequestHandler<GetStationDataRequest, List<GetStationDataResponse>>
    {
        private readonly IStationDataRepository _stationDataRepository;
        private readonly IMapper _mapper;

        public GetStationDataHandler(IStationDataRepository stationDataRepository, IMapper mapper)
        {
            _stationDataRepository = stationDataRepository;
            _mapper = mapper;
        }

        public async Task<List<GetStationDataResponse>> Handle(GetStationDataRequest request, CancellationToken cancellationToken)
        {
            var stationData = await _stationDataRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetStationDataResponse>>(stationData);
        }
    }
}
