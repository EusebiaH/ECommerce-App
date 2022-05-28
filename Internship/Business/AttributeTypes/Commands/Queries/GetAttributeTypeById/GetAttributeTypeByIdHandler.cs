using AutoMapper;
using Internship.Controllers.AttributeTypes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.AttributeTypes.Commands.Queries.GetAttributeTypeById
{
    public class GetAttributeTypeByIdHandler : IRequestHandler<GetAttributeTypeByIdQuery, AttributeTypeResult>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public GetAttributeTypeByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<AttributeTypeResult> Handle(GetAttributeTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var AttributeType = await _DbContext.AttributeTypes.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (AttributeType == null)
            {
                return null;
            }
            else
            {
                var getUserResult = _mapper.Map<AttributeTypeResult>(AttributeType);
                return getUserResult;
            }
        }
    }
}
