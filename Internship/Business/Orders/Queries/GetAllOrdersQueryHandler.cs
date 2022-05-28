using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Orders.Queries
{
    public class GetAllOrdersQueryHandler: IRequestHandler<GetAllOrdersQuery, List<Order>>
    {
        private readonly EcomDbContext _dbContext;  

        public GetAllOrdersQueryHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext; 
        }


        public async Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var order =await _dbContext.Orders.ToListAsync();
            return order; 

        }



    }
}
