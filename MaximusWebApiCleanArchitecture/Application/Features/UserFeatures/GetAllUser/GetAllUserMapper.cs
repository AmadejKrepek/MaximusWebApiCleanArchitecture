using AutoMapper;
using Domain.Entities;

namespace Application.Features.UserFeatures.GetAllUser
{
    public class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
