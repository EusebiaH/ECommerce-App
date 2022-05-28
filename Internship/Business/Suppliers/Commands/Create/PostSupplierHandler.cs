using AutoMapper;
using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Create
{
    public class PostSupplierHandler : IRequestHandler<PostSupplierCommand, PostSupplierResult>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;
        
        public PostSupplierHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PostSupplierResult> Handle(PostSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Supplier>(request);
            _dbContext.Suppliers.Add(supplier);
            _dbContext.SaveChanges();
            var supplierResult = _mapper.Map<PostSupplierResult>(supplier);
            return supplierResult;
        }
    }
}
