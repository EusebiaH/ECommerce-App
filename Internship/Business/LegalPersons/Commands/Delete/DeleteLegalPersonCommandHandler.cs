using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.LegalPersons.Commands.Delete
{
    public class DeleteLegalPersonCommandHandler:IRequestHandler<DeleteLegalPersonCommand,string>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public DeleteLegalPersonCommandHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<string> Handle(DeleteLegalPersonCommand request, CancellationToken cancellationToken)
        {
            var legalPerson = await _dbContext.LegalPersons.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (legalPerson == null)
                return null;
            else
            {
                _dbContext.LegalPersons.Remove(legalPerson);
                return "Person Deleted";
            }

        }
    }
}
