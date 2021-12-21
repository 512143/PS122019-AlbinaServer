using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.Core.Models;

namespace Bor_Server.AutoMapperProfiles
{
    public class MicroserviceProfile : Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<UserInformationBlo, UserInformationDto>();
            CreateMap<UserIdentityBlo, UserIdentityDto>();
        }
    }
}
