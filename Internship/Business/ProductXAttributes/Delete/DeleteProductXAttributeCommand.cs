using MediatR;

namespace Internship.Business.ProductXAttributes.Delete
{
    public class DeleteProductXAttributeCommand:IRequest<string>
    {
        public int Id { get; set; }
        public DeleteProductXAttributeCommand(int id)
        {
            Id = id;
        }
    }
}
