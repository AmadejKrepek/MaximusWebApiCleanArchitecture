using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StationDataFeatures.CreateStationData
{
    public sealed class CreateStationDataHandler : IRequestHandler<CreateStationDataRequest, CreateStationDataResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationDataRepository _stationDataRepository;
        private readonly IMapper _mapper;

        public CreateStationDataHandler(IUnitOfWork unitOfWork, IStationDataRepository stationDataRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationDataRepository = stationDataRepository;
            _mapper = mapper;
        }

        public async Task<CreateStationDataResponse> Handle(CreateStationDataRequest request, CancellationToken cancellationToken)
        {
            var stationData = _mapper.Map<StationData>(request);
            _stationDataRepository.Create(stationData);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateStationDataResponse>(stationData);
        }
    }
}
