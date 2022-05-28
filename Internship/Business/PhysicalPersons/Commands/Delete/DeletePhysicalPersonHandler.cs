using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace Internship.Business.PhysicalPersons.Commands.Delete
{
    public class DeletePhysicalPersonHandler : IRequestHandler<DeletePhysicalPersonCommand, string>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeletePhysicalPersonHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(DeletePhysicalPersonCommand request, CancellationToken cancellationToken)
        {
            var physicalPerson = await _dbContext.PhysicalPersons.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (physicalPerson != null)
            {
                _dbContext.PhysicalPersons.Remove(physicalPerson);
                await _dbContext.SaveChangesAsync();
                return "Physical Person Deleted";
            }
            return "Physical Person doesn't exist";
        }
    }
}
