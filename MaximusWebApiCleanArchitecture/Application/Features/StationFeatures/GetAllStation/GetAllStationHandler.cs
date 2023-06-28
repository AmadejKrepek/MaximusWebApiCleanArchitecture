using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.StationFeatures.GetAllStation
{
    public sealed class GetAllStationHandler : IRequestHandler<GetAllStationRequest, List<GetAllStationResponse>>
    {
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public GetAllStationHandler(IStationRepository stationRepository, IMapper mapper)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllStationResponse>> Handle(GetAllStationRequest request, CancellationToken cancellationToken)
        {
            var stations = await _stationRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllStationResponse>>(stations);
        }
    }
}
