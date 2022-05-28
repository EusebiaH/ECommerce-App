using AutoMapper;
using Internship.Business.Attributes.Commands.Create;
using Internship.Business.Attributes.Commands.Update;
using Internship.Data;
using Attribute = Internship.Data.Attribute;

namespace Internship.Controllers.Attributes.Mappings
{
    public class AttributeMapper : Profile
    {
        public  AttributeMapper()
        {
            CreateMap<Attribute,GetAttributes>();

            CreateMap<PostAttributeCommand, Attribute>();
            CreateMap<Attribute, PostAttributeResult>().ForMember(x => x.AttributeTypeId, map => map.MapFrom(a => a.AttributeType.Id));
            
            CreateMap<Attribute, GetAttributeById>();

            CreateMap<Attribute, UpdateAttributeCommand>();
            CreateMap<UpdateAttributeCommand, UpdateAttributeResult>();
                                                                
        }
    }
}
