using MediatR;

namespace Internship.Business.ProductTypes.Commands.Delete
{
    public class DeleteProductTypeCommand : IRequest<string>
    {
        public int Id { get; set; }

        public DeleteProductTypeCommand(int id)
        {
            Id = id;
        }
    }
}
