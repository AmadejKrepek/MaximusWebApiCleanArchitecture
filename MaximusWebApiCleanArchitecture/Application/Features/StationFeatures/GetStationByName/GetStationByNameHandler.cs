using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.StationFeatures.GetStationById
{
    public sealed class GetStationByNameHandler : IRequestHandler<GetStationByNameRequest, List<GetStationByNameResponse>> 
    {
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public GetStationByNameHandler(IStationRepository stationRepository, IMapper mapper)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;
        }
        public async Task<List<GetStationByNameResponse>> Handle(GetStationByNameRequest request, CancellationToken cancellationToken)
        {
            var station = await _stationRepository.GetStationByName(request, cancellationToken);
            return _mapper.Map<List<GetStationByNameResponse>>(station);
        }
    }
}
