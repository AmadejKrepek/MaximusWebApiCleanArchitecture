using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed class CreateStationHandler : IRequestHandler<CreateStationRequest, CreateStationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public CreateStationHandler(IUnitOfWork unitOfWork, IStationRepository stationRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        public async Task<CreateStationResponse> Handle(CreateStationRequest request, CancellationToken cancellationToken)
        {
            var station = _mapper.Map<Station>(request);
            _stationRepository.Create(station);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateStationResponse>(station);
        }
    }
}
