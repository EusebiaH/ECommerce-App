using AutoMapper;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategoryXAttributes.Queries.GetById
{
    public class GetProductCategoryXAttributeByIdHandler : IRequestHandler<GetProductCategoryXAttributeByIdQuery, GetProductCategoryXAttributeById>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetProductCategoryXAttributeByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<GetProductCategoryXAttributeById> Handle(GetProductCategoryXAttributeByIdQuery request, CancellationToken cancellationToken)
        {
            var ProdCatXAtt = await _dbContext.ProductCategoryXAttributes.Include(x => x.Attribute)
                                                    .Include(p => p.ProductCategory).Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            var ProdCatXAttMap=_mapper.Map<GetProductCategoryXAttributeById>(ProdCatXAtt);

            return ProdCatXAttMap;
        }
    }
}
