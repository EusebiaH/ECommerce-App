using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Commands.Delete
{
    public class DeleteProductCommand:IRequest<string>
    {
        public int Id { get; set; }
        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
