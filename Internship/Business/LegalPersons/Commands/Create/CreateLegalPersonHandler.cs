using AutoMapper;
using Internship.Controllers.LegalPersons.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Create
{
    public class CreateLegalPersonHandler : IRequestHandler<CreateLegalPersonCommand,PostLegalPersonResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CreateLegalPersonHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<PostLegalPersonResult> Handle(CreateLegalPersonCommand request, CancellationToken cancellationToken)
        {
            var legalPerson = _mapper.Map<LegalPerson>(request);
            _dbContext.Add(legalPerson);
            _dbContext.SaveChanges();
            var result = _mapper.Map<PostLegalPersonResult>(legalPerson);
            return result;
        }
    }
}
