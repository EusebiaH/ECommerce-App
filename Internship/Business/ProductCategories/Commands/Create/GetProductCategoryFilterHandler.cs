using AutoMapper;
using Internship.Business.ProductCategories.Queries;
using Internship.Data;
using Internship.Data.ProductCategorys;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class GetProductCategoryFilterHandler : IRequestHandler<GetProductCategoryFilterQuery, GetProductCategoryIdResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetProductCategoryFilterHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public async Task<GetProductCategoryIdResult> Handle(GetProductCategoryFilterQuery request, CancellationToken cancellationToken)
        {
            var prod = await _dbContext.ProductCategorys.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            var prodCopy = _mapper.Map<GetProductCategoryIdResult>(prod);
            return prodCopy;
        }
    }
}
