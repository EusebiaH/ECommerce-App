using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Delete
{
    public class DeleteAttributeTypeCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteAttributeTypeCommand(int id)
        {
            Id = id;
        }
    }
}
