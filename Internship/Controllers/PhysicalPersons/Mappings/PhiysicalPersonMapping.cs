using AutoMapper;
using Internship.Business.PhysicalPersons.Commands.Create;
using Internship.Business.PhysicalPersons.Commands.Delete;
using Internship.Business.PhysicalPersons.Commands.Update;
using Internship.Controllers.PhysicalPersons.Models;
using Internship.Data;

namespace Internship.Controllers.PhysicalPersons.Mappings
{
    public class PhiysicalPersonMapping: Profile

    {
        public PhiysicalPersonMapping()
        {
            CreateMap<PhysicalPerson, CreatePhysicalPersonResult>(); //key in map
            CreateMap<CreatePhysicalPersonCommand, CreatePhysicalPersonResult>();
            CreateMap<DeletePhysicalPersonCommand, PhysicalPerson>();
            CreateMap<PhysicalPerson, DeletePhysicalPersonCommand>();
            CreateMap<PhysicalPerson, UpdatePhysicalPersonResult>(); //key in map
            CreateMap<PutPhysicalPersonRequest, UpdatePhysicalPersonCommand>();
            CreateMap<PhysicalPerson, GetByIdPhysicalPersonResult>(); //key in map
            CreateMap<PostPhysicalPersonRequest, CreatePhysicalPersonCommand>();
            CreateMap<CreatePhysicalPersonCommand, PhysicalPerson>(); 

            CreateMap<PhysicalPerson, CreatePhysicalPersonResult>().ForMember(p=>p.UserId, map=>map.MapFrom(prop=>prop.User.Id));
            CreateMap<PhysicalPerson, UpdatePhysicalPersonResult>().ForMember(p => p.UserId, map => map.MapFrom(prop => prop.User.Id));
            CreateMap<PhysicalPerson, GetByIdPhysicalPersonResult>().ForMember(p => p.UserId, map => map.MapFrom(prop => prop.User.Id));

  
        }
    }
}
