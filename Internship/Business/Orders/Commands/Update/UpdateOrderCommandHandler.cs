using AutoMapper;
using Internship.Controllers;
using Internship.Data;
using MediatR;

namespace Internship.Business.Orders.Commands.Update
{
    public class UpdateOrderCommandHandler: IRequestHandler<UpdateOrderCommand, UpdateOrderResult>
    {
        public EcomDbContext _dbContext;

        public IMapper _mapper; 

        public UpdateOrderCommandHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



        public async Task<UpdateOrderResult> Handle(UpdateOrderCommand command , CancellationToken cancellationToken)
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == command.Id);

            if (order == null)
                return null;
            else
            {
                var product = _mapper.Map<Order>(order); 
                _dbContext.SaveChanges();
                var product1 = _mapper.Map<UpdateOrderResult>(product);
                return product1; 


            }



        }



    }
}
