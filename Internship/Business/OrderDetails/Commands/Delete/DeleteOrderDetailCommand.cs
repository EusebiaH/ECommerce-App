using MediatR;

namespace Internship.Business.OrderDetails.Commands.Delete
{
    public class DeleteOrderDetailCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteOrderDetailCommand(int id)
        {
            Id = id;
        }
    }
}
