using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Orders.Queries
{
    public class GetAllOrdersByIdHandler: IRequestHandler<GetAllOrdersByIdQuery, Order>
    {
        private readonly IMapper _mapper;

        private readonly EcomDbContext _dbContext; 

        public GetAllOrdersByIdHandler(IMapper mapper , EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Order> Handle(GetAllOrdersByIdQuery command, CancellationToken cancellationToken )
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == command.Id); 
            if ( order == null )
                return null;
            else
            {
                return (order);
            }

        }



    }
}
