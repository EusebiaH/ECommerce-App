using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Addresses.Queries
{
    public class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQuery , List<Address>>
    {
        private readonly EcomDbContext _dbContext;


        public GetAllAddressesQueryHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Address>> Handle(GetAllAddressesQuery request, CancellationToken  cancellationToken)
        {
            var destination =await _dbContext.Addresses.ToListAsync();
            return destination; 
        }



    }
}
