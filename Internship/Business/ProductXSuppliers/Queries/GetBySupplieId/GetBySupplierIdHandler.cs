using AutoMapper;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductXSuppliers.Queries.GetBySupplieId
{
    public class GetBySupplierIdHandler: IRequestHandler<GetBySupplierIdQuery, List<GetBySupplierIdResult>>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public GetBySupplierIdHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetBySupplierIdResult>> Handle(GetBySupplierIdQuery request, CancellationToken cancellationToken)
        {
            var psList = await _dbContext.ProductXSuppliers.Where(x => x.SupplierId == request.SupplierId).ToListAsync();
            var psListResult = _mapper.Map<List<GetBySupplierIdResult>>(psList);
            return psListResult;

        }
        
    }
}
