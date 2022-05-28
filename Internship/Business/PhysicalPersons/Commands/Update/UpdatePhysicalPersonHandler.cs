using AutoMapper;
using Internship.Controllers.PhysicalPersons.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.PhysicalPersons.Commands.Update

{
    public class UpdatePhysicalPersonHandler : IRequestHandler<UpdatePhysicalPersonCommand, UpdatePhysicalPersonResult>
{
    private readonly EcomDbContext _dbContext;
    private readonly IMapper _mapper;
    public UpdatePhysicalPersonHandler(EcomDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public async Task<UpdatePhysicalPersonResult> Handle(UpdatePhysicalPersonCommand request, CancellationToken cancellationToken)
    {
        var physicalPerson = _dbContext.PhysicalPersons.FirstOrDefault(x => x.Id == request.Id);
        if (physicalPerson == null)
            return null;
        
        physicalPerson.FirstName = request.FirstName;
        physicalPerson.Surname = request.Surname;
        physicalPerson.Birthday = request.Birthday;
        physicalPerson.UserId = request.UserId;
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<UpdatePhysicalPersonResult>(physicalPerson);

    }

}
}
