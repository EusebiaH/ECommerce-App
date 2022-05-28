using AutoMapper;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategoryXAttributes.Queries.Filter
{
    public class GetAllProductCategoryXAtributeHandler : IRequestHandler<GetAllProductCategoryXAttributeQuery, List<GetAllProductCategoryXAttributeResult>>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetAllProductCategoryXAtributeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllProductCategoryXAttributeResult>> Handle(GetAllProductCategoryXAttributeQuery request, CancellationToken cancellationToken)
        {
            var ProdCatXAttribute = await _dbContext.ProductCategoryXAttributes.Include(x=>x.Attribute)
                                                    .Include(p=>p.ProductCategory).ToListAsync();
        
            var ProdCatXAttributeResult=_mapper.Map<List<GetAllProductCategoryXAttributeResult>>(ProdCatXAttribute);

            return ProdCatXAttributeResult;
        }
    }
}
