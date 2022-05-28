using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Queries.GetById
{
    public class GetByIdProductXAttributeHandler : IRequestHandler<GetByIdProductXAttributeQuery, ProductXAttribute>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GetByIdProductXAttributeHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<ProductXAttribute> Handle(GetByIdProductXAttributeQuery request, CancellationToken cancellationToken)
        {
            var find = _dbContext.ProductXAttributes.FirstOrDefault(x => x.Id == request.Id);
            if (find == null)
                return null;
            return find;
        }
    }
}
