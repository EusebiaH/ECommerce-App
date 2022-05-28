using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        public GetProductByIdQueryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _dbContext.Products.FirstOrDefault(x => x.Id == request.Id);
            if (result == null)
                return null;
            else
                return (result);
        }
    }
}
