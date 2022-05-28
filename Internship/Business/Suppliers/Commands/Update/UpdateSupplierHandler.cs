using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Update
{
    public class UpdateSupplierHandler: IRequestHandler<UpdateSupplierCommand, string>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public UpdateSupplierHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = _dbContext.Suppliers.FirstOrDefault(x => x.Name == request.Name);
            if (supplier == null)
                return ("Nu exista acest distribuitor!");
            else
            {
                supplier.AddressId = request.AddressId;
                _dbContext.SaveChanges();
                return ("Locatie modificata!");
            }
            

        }

    }
}
