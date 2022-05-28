
using AutoMapper;
using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductTypes.Queries.Filter
{
    public class FIlterProductTypeHandler : IRequestHandler<FIlterProductTypeQuery, List<GetAllProductTypeResult>>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;

        public FIlterProductTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<GetAllProductTypeResult>> Handle(FIlterProductTypeQuery request, CancellationToken cancellationToken)
        {
            var search = _dbContext.ProductsType;
            var prodTypeList=_mapper.Map<List<GetAllProductTypeResult>>(search);
            return prodTypeList;
        }
    }
}
