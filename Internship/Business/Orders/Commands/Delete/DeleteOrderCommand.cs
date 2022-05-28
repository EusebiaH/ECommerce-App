using MediatR;

namespace Internship.Business.Orders.Commands.Delete
{
    public class DeleteOrderCommand: IRequest<string>
    {
        public int Id { get; set; }

        public DeleteOrderCommand (int id)
        {
            Id = id;    
        }



    }
}
