using AutoMapper;
using Internship.Controllers;
using Internship.Controllers.Addresses.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Commands.Create
{
    public class PostAddressCommandHandler : IRequestHandler<PostAddressCommand ,PostAddressResult>
    {
        private readonly IMapper _mapper;

        private readonly EcomDbContext _dbContext; 

        public PostAddressCommandHandler(IMediator mediator ,IMapper mapper , EcomDbContext dbContext)
        {
            _mapper = mapper;   
            _dbContext = dbContext;
        }

        public async Task<PostAddressResult> Handle(PostAddressCommand address , CancellationToken cancellationToken)
        {
            var address1 = _mapper.Map<Address>(address); 

            if(address1 == null)
                return null;    
            else
            {
                _dbContext.Addresses.Add(address1); 
                _dbContext.SaveChanges();
            }

            return _mapper.Map<PostAddressResult>(address1);

        }




    }
}
