using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.OrderDetails.Commands.Delete
{
    public class DeleteOrderDetailCommandHandler : IRequestHandler<DeleteOrderDetailCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public DeleteOrderDetailCommandHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<string> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
        {
            var orderDetail = await _dbContext.OrdersDetail.FirstOrDefaultAsync(x=>x.Id == request.Id);
            _dbContext.OrdersDetail.Remove(orderDetail);
            _dbContext.SaveChanges();
            return "Object Deleted";

        }
    }
}
