using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.StationDataFeatures.GetStationDataByStationId
{
    public sealed class GetStationDataByStationIdHandler : IRequestHandler<GetStationDataByStationIdRequest, List<GetStationDataByStationIdResponse>>
    {
        private readonly IStationDataRepository _stationDataRepository;
        private readonly IMapper _mapper;

        public GetStationDataByStationIdHandler(IStationDataRepository stationDataRepository, IMapper mapper)
        {
            _stationDataRepository = stationDataRepository;
            _mapper = mapper;
        }

        public async Task<List<GetStationDataByStationIdResponse>> Handle(GetStationDataByStationIdRequest request, CancellationToken cancellationToken)
        {
            var stationData = await _stationDataRepository.GetStationDataByStationId(request, cancellationToken);
            return _mapper.Map<List<GetStationDataByStationIdResponse>>(stationData);
        }
    }
}
