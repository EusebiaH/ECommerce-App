using AutoMapper;
using Internship.Business.AttributeTypes.Commands.Create;
using Internship.Controllers.AttributeTypes.Models;
using Internship.Data;

namespace Internship.Controllers.AttributeTypes.Mappings
{
    public class AttributeTypeMapping : Profile
    {
       public AttributeTypeMapping()
       {
            CreateMap<AttributeType, AttributeTypeResult>();
            CreateMap<CreateNewAttributeTypeCommand,AttributeType>();
            CreateMap<CreateAttributeType, CreateNewAttributeTypeCommand>();
       }
    }
}
