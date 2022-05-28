using AutoMapper;
using Internship.Controllers.LegalPersons.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Update
{
    public class UpdateLegalPersonCommandHandler : IRequestHandler<UpdateLegalPersonCommand, UpdateLegalPersonResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateLegalPersonCommandHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UpdateLegalPersonResult> Handle(UpdateLegalPersonCommand request, CancellationToken cancellationToken)
        {
            var person = _dbContext.LegalPersons.FirstOrDefault(x => x.Id == request.Id);
            person.CUI = request.CUI;
            person.UserId = request.UserId;
            _dbContext.SaveChanges();
            return _mapper.Map<UpdateLegalPersonResult>(person);
        }
    }
}
