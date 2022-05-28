using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Create
{
    public class CreateNewAttributeTypeCommand : IRequest<string>
    { 
        public string Name { get; set; }
    }
}
