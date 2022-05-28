using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Users.Commands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public CreateUserHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return "Cannot insert a user that is null.";
            else
            {
                if(request.UserTypeId == 1 || request.UserTypeId == 2)
                {
                    var insertuser = _mapper.Map<User>(request);
                    _DbContext.Users.Add(insertuser);
                    await _DbContext.SaveChangesAsync();
                    return "The user has been created.";
                }
                else { return "The UserType is incorrect! Values can be either 1 or 2!"; }
            }
        }
    }
}
