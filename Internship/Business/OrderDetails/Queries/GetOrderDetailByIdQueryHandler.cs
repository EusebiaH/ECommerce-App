using AutoMapper;
using Internship.Controllers.OrderDetails.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.OrderDetails.Queries
{
    public class GetOrderDetailByIdQueryHandler : IRequestHandler<GetOrderDetailByIdQuery, GetOrderDetailByIdResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetOrderDetailByIdQueryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<GetOrderDetailByIdResult> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var orderDetail = await _dbContext.OrdersDetail.FirstOrDefaultAsync(x=>x.Id == request.Id);
            var result = _mapper.Map<GetOrderDetailByIdResult>(orderDetail);
            return result;
        }
    }
}
