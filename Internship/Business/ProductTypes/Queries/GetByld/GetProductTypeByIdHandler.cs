using AutoMapper;
using Internship.Data;
using Internship.Data.ProductsType;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductTypes.Queries.GetByld
{
    public class GetProductTypeByIdHandler : IRequestHandler<GetProductTypeByIdQuery, List<GetProductTypeByIdResult>>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProductTypeByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetProductTypeByIdResult>> Handle(GetProductTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var items = await _dbContext.ProductsType.Where(x => x.Id == request.Id).ToListAsync();
            var ItemsCopy = _mapper.Map<List<GetProductTypeByIdResult>>(items);
            return ItemsCopy;


        }
    }
}

