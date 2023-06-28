using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed class UpdateStationHandler : IRequestHandler<UpdateStationRequest, UpdateStationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public UpdateStationHandler(IUnitOfWork unitOfWork, IStationRepository stationRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        public async Task<UpdateStationResponse> Handle(UpdateStationRequest request, CancellationToken cancellationToken)
        {
            var station = _mapper.Map<Station>(request);
            _stationRepository.Update(station);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<UpdateStationResponse>(station);
        }
    }
}
