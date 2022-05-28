using AutoMapper;
using Internship.Controllers.AttributeTypes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.AttributeTypes.Commands.Queries.GetAllAttributeTypes
{
    public class GetAllAttributeTypesHandler : IRequestHandler<GetAllAttributeTypesQuery, List<AttributeTypeResult>>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public GetAllAttributeTypesHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        
        public async Task<List<AttributeTypeResult>> Handle(GetAllAttributeTypesQuery request, CancellationToken cancellationToken)
        {
            var results = await _DbContext.AttributeTypes.ToListAsync();
            var getUserResults = _mapper.Map<List<AttributeTypeResult>>(results);
            return getUserResults;
        }
    }
}
