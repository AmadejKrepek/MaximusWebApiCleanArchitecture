using Application.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.StationDataFeatures.CreateStationData
{
    public sealed class CreateStationDataHandler : IRequestHandler<CreateStationDataRequest, CreateStationDataResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;


    }
}
