using AutoMapper;
using Internship.Business.Orders.Commands.Create;
using Internship.Controllers;
using Internship.Data;
using MediatR;

namespace Internship.Business
{
    public class PostOrderCommandHandler: IRequestHandler<PostOrderCommand,PostOrderResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;



        public PostOrderCommandHandler(IMediator mediator , IMapper mapper, EcomDbContext dbContext)
        {

            _mapper = mapper;   
            _dbContext = dbContext; 

        }

       public async Task<PostOrderResult> Handle(PostOrderCommand command, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Order>(command);
            if (result == null)
                return null;
            else
            {
                _dbContext.Orders.Add(result); 
                _dbContext.SaveChanges();
               
            }
            return _mapper.Map<PostOrderResult>(result);
        }



    }
}
