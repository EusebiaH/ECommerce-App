using AutoMapper;
using Internship.Controllers.Addresses.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Commands.Update
{
    public class UpdateAddressCommandHandler: IRequestHandler<UpdateAddressCommand , UpdateAddressResult>
    {
        public EcomDbContext _dbContext;

        public IMapper _mapper;

        public UpdateAddressCommandHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }   


        public async Task<UpdateAddressResult> Handle(UpdateAddressCommand address , CancellationToken cancellationtoken)
        {
            var address1 = _dbContext.Addresses.FirstOrDefault(x => x.Id == address.Id);

            if (address1 == null)
                return null; 
            else
            {
                var address2 = _mapper.Map<Address>(address1);
                _dbContext.SaveChanges();
                var address3 = _mapper.Map<UpdateAddressResult>(address2);
                return address3; 
            }


        }


    }
}
