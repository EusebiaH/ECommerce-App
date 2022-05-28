using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Queries
{
    public class GetAllAddressesByIdHandler : IRequestHandler<GetAllAddressesByIdQuery, Address>
    {
        private readonly EcomDbContext _dbContext;

        private readonly IMapper _mapper; 

        public GetAllAddressesByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Address> Handle(GetAllAddressesByIdQuery dest, CancellationToken cancellationToken)
        {
            var address = _dbContext.Addresses.FirstOrDefault(x => x.Id == dest.Id);
            if (address == null)    
                return null;    
            else
            {
                return address;
            }


        }


    }
}
