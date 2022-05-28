using AutoMapper;
using Internship.Business.ProductXSuppliers.Commands.Create;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductXSuppliers.Queries.GetAll
{
    public class GetAllPsHandler: IRequestHandler<GetAllPsQuery, List<GetAllPsResult>>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public GetAllPsHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllPsResult>> Handle(GetAllPsQuery request, CancellationToken cancellationToken)
        {
            var psList = await _dbContext.ProductXSuppliers.Include(x=>x.Product).Include(x=>x.Supplier).ToListAsync();
            var psListResult = _mapper.Map<List<GetAllPsResult>>(psList);

            //foreach (var ps in psListResult)
          // {
           //     ps.ProductName = _dbContext.Products.FirstOrDefault(x => x.Id == ps.ProductId).Name;
          //      ps.SupplierName = _dbContext.Suppliers.FirstOrDefault(x => x.Id == ps.SupplierId).Name;
           // }

            return psListResult;
        } 
 
    }
}
