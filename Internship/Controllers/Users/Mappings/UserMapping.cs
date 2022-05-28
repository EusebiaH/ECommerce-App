using AutoMapper;
using Internship.Business.Users.Commands.Create;
using Internship.Business.Users.Commands.Update;
using Internship.Controllers.Users.Models;
using Internship.Data;

namespace Internship.Controllers.Users.Mappings
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, GetUserResult>().ForMember(g => g.UserType, map => map.MapFrom(g => g.UserType.Name));
            CreateMap<CreateUserRequest, CreateUserCommand>();
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
        }
    }
}
