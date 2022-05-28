using MediatR;

namespace Internship.Business.Attributes.Commands.Create
{
    public class PostAttributeCommand : IRequest<Data.Attribute>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int? AttributeTypeId { get; set; }

        public PostAttributeCommand(string name, bool active, int attributeTypeId)
        {
            Name = name;
            Active = active;
            AttributeTypeId=attributeTypeId;
        }
        
    }
}
