using Internship.Controllers.AttributeTypes.Models;
using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Update
{
    public class UpdateAttributeTypeCommand : IRequest<string>
    {
        private UpdateAttributeType updateAttributeType;

        public UpdateAttributeTypeCommand(int id, UpdateAttributeType updateAttributeType)
        {
            Id = id;
           Name = updateAttributeType.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
