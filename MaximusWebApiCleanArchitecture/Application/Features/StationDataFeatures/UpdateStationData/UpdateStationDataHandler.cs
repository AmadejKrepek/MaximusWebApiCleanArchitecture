using Application.Repositories;
using AutoMapper;

namespace Application.Features.StationDataFeatures.UpdateStationData
{
    public sealed class UpdateStationDataHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationDataRepository _stationDataRepository;
        private readonly IMapper _mapper;

        public UpdateStationDataHandler(IUnitOfWork unitOfWork, IStationDataRepository stationDataRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationDataRepository = stationDataRepository;
            _mapper = mapper;
        }
    }
}
