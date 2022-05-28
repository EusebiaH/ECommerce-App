using Internship.Data;
using MediatR;

namespace Internship.Business.Orders.Commands.Delete
{
    public class DeleteOrderCommandHandler: IRequestHandler<DeleteOrderCommand, string>
    {
        public EcomDbContext _dbContext; 


        public DeleteOrderCommandHandler(EcomDbContext dbContext)
        {

            _dbContext = dbContext; 
        }

        public async Task<string> Handle(DeleteOrderCommand command ,  CancellationToken cancellationToken)
        {

            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == command.Id);

            if (order == null)
                return null;
            else
            {
                _dbContext.Orders.Remove(order);
                _dbContext.SaveChanges();
                return "Order Deleted"; 
            }


        }




    }
}
