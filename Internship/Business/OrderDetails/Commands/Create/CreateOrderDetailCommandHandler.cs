using AutoMapper;
using Internship.Business.Orders.Commands.Create;
using Internship.Controllers.OrderDetails.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.OrderDetails.Commands.Create
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, PostOrderDetailResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public CreateOrderDetailCommandHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<PostOrderDetailResult> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            var orderDetail = _mapper.Map<OrderDetail>(request);
            await _dbContext.OrdersDetail.AddAsync(orderDetail);
            _dbContext.SaveChanges();
            return _mapper.Map<PostOrderDetailResult>(orderDetail);
        }
    }
}
