using AutoMapper;
using Internship.Business.LegalPersons.Commands.Create;
using Internship.Business.LegalPersons.Commands.Update;
using Internship.Controllers.LegalPersons.Models;
using Internship.Data;

namespace Internship.Controllers.LegalPersons.Mappings
{
    public class LegalPersonMapping : Profile
    {
        public LegalPersonMapping()
        {
            CreateMap<PostLegalPersonRequest, CreateLegalPersonCommand>();
            CreateMap<CreateLegalPersonCommand, LegalPerson>();
            CreateMap<LegalPerson, PostLegalPersonResult>();

            CreateMap<LegalPerson, GetLegalPersonByIdResult>();

            CreateMap<UpdateLegalPersonRequest, UpdateLegalPersonCommand>();

            CreateMap<UpdateLegalPersonCommand, LegalPerson>();
            CreateMap<LegalPerson, UpdateLegalPersonResult>();
        }
    }
}
