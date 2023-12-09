using AutoMapper;
using sn_project_be.Core.Models.Posts;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        CreateMap<ApiUser, GetAllUsersDto>();
        CreateMap<ApiUser, GetUserDto>();
        CreateMap<ApiUser, 
                UpdateUserDto>().ReverseMap()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));
        
        CreateMap<CreatePost, Post>().ReverseMap();
    }
}