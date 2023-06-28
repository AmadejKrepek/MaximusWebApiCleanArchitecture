using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StationFeatures.DeleteStation
{
    public sealed class DeleteStationHandler : IRequestHandler<DeleteStationRequest, DeleteStationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public DeleteStationHandler(IUnitOfWork unitOfWork, IStationRepository stationRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        public async Task<DeleteStationResponse> Handle(DeleteStationRequest request, CancellationToken cancellationToken)
        {
            var station = _mapper.Map<Station>(request);
            _stationRepository.Delete(station);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<DeleteStationResponse>(station);
        }
    }
}
