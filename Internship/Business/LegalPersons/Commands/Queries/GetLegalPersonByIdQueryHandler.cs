using AutoMapper;
using Internship.Controllers.LegalPersons.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Queries
{
    public class GetLegalPersonByIdQueryHandler : IRequestHandler<GetLegalPersonByIdQuery, GetLegalPersonByIdResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetLegalPersonByIdQueryHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetLegalPersonByIdResult> Handle(GetLegalPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var legalPerson = _dbContext.LegalPersons.FirstOrDefault(x => x.Id == request.Id);
            var result = _mapper.Map<GetLegalPersonByIdResult>(legalPerson);
            return result;
        }
    }
}
