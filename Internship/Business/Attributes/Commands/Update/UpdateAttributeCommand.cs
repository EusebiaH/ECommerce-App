using Internship.Data;
using MediatR;

namespace Internship.Business.Attributes.Commands.Update
{
    public class UpdateAttributeCommand : IRequest<UpdateAttributeResult>
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool Active { get; set; }

        //public int? AttributeTypeId { get; set; }
    }
}
