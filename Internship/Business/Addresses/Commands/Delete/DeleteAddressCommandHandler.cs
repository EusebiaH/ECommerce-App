using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Commands.Delete
{
    public class DeleteAddressCommandHandler: IRequestHandler<DeleteAddressCommand , string>
    {
        public EcomDbContext _dbContext; 


        public DeleteAddressCommandHandler(EcomDbContext dbContext)

        {
            _dbContext = dbContext; 
        }

        public async Task<string> Handle(DeleteAddressCommand address , CancellationToken cancellationToken)
        {
            var address1 = _dbContext.Addresses.FirstOrDefault(x => x.Id == address.Id);

            if (address1 == null)   
                return null;    
            else
            {
                _dbContext.Addresses.Remove(address1);
                _dbContext.SaveChanges();
                return "Address deleted"; 
            }


        }


    }
}
