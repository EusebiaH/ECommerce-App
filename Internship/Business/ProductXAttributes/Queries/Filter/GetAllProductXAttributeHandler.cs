using AutoMapper;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductXAttributes.Queries.Filter
{
    public class GetAllProductXAttributeHandler : IRequestHandler<GetAllProductXAttributeQuery, List<GetAllProductXAttributeResult>>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GetAllProductXAttributeHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<List<GetAllProductXAttributeResult>> Handle(GetAllProductXAttributeQuery request, CancellationToken cancellationToken)
        {
            var products = await _dbContext.ProductXAttributes
                .Include(x => x.Product).ThenInclude(x => x.ProductType)
                .Include(x => x.Attribute).ThenInclude(a => a.AttributeType)
                .Include(x => x.Product).ThenInclude(x => x.ProductCategory)
                .Include(x => x.Product).ThenInclude(x => x.Manufacturer)
                .Include(x => x.Product).ThenInclude(x => x.VAT).ToListAsync();
            var x = _mapper.Map< List<GetAllProductXAttributeResult>>(products);
            return x;

        }
    }
}
