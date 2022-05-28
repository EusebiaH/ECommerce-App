using AutoMapper;
using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Delete
{
    public class DeleteSupplierHandler: IRequestHandler<DeleteSupplierCommand, string>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public DeleteSupplierHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = _dbContext.Suppliers.FirstOrDefault(x => x.Name == request.Name);
            if (supplier == null)
                return("Nu exista acest distribuitor!");
            else
                _dbContext.Suppliers.Remove(supplier);
                _dbContext.SaveChanges();
                return ("Distribuitor sters");

        }


    }
}
