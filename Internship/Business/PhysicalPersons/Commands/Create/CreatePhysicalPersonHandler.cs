using MediatR;
using Internship.Data;
using AutoMapper;
using Internship.Controllers.PhysicalPersons.Models;

namespace Internship.Business.PhysicalPersons.Commands.Create
{
    public class CreatePhysicalPersonHandler: IRequestHandler<CreatePhysicalPersonCommand, CreatePhysicalPersonResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        public CreatePhysicalPersonHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CreatePhysicalPersonResult> Handle(CreatePhysicalPersonCommand request, CancellationToken cancellationToken)
        {
            var physicalPerson = _mapper.Map<PhysicalPerson>(request);
            _dbContext.PhysicalPersons.Add(physicalPerson);
            await _dbContext.SaveChangesAsync();
            var newPhysicalPerson = _mapper.Map<CreatePhysicalPersonResult>(physicalPerson);
            return newPhysicalPerson;
        }
    }
}
