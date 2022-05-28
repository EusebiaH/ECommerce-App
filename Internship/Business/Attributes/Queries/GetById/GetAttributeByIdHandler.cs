using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Attributes.Queries.GetById
{
    public class GetAttributeByIdHandler : IRequestHandler<GetAttributeByIdQuery, GetAttributeById>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public GetAttributeByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<GetAttributeById> Handle(GetAttributeByIdQuery request, CancellationToken cancellationToken)
        {
            var att = await _dbContext.Attributes.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            var attcopy = _mapper.Map<GetAttributeById>(att);
            return attcopy;
        }
    }
}
