using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.OrderDetails.Queries
{
    public class GetAllOrderDetailsQueryHandler : IRequestHandler<GetAllOrderDetailsQuery,List<OrderDetail>>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetAllOrderDetailsQueryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<OrderDetail>> Handle(GetAllOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var orderDetails = await _dbContext.OrdersDetail.ToListAsync();
            return orderDetails;
        }
    }
}
