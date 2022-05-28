using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductTypes.Commands.Delete
{
    public class DeleteProductTypeHandler : IRequestHandler<DeleteProductTypeCommand, string>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;

        public DeleteProductTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteProductTypeCommand request, CancellationToken cancellationToken)
        {

            var productType = await _dbContext.ProductsType.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (productType != null)
            {
                _dbContext.ProductsType.Remove(productType);
                await _dbContext.SaveChangesAsync();
                return "Product Type with Name =  " + productType.Name + " Deleted";
            }
            return "This product type dosen't exist!";
        }
    }
}
