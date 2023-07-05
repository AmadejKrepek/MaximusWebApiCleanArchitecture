using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StationDataFeatures.DeleteStationData
{
    public sealed class DeleteStationDataHandler : IRequestHandler<DeleteStationDataRequest, DeleteStationDataResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationDataRepository _stationDataRepository;
        private readonly IMapper _mapper;

        public DeleteStationDataHandler(IUnitOfWork unitOfWork, IStationDataRepository stationDataRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _stationDataRepository = stationDataRepository;
            _mapper = mapper;
        }

        public async Task<DeleteStationDataResponse> Handle(DeleteStationDataRequest request, CancellationToken cancellationToken)
        {
            var stationData = _mapper.Map<StationData>(request);
            _stationDataRepository.Delete(stationData);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<DeleteStationDataResponse>(stationData);
        }
    }
}
