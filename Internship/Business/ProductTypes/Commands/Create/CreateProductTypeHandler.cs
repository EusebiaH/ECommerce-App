using AutoMapper;
using Internship.Business.ProductTypes.Commands.Create;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductTypes.Commands.Delete
{
    public class CreateProductTypeHandler : IRequestHandler<CreateProductTypeCommand,ProductType>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateProductTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProductType> Handle(CreateProductTypeCommand request, CancellationToken cancellationToken)
        {
            var prodType= _mapper.Map<ProductType>(request);
            _dbContext.ProductsType.Add(prodType);
            _dbContext.SaveChanges();
            return prodType;
        }
    }
}
