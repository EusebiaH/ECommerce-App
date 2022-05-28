using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Users.Commands.Update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public UpdateUserHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var updatedUser = _DbContext.Users.FirstOrDefault(x => x.Id == request.Id);
            if (updatedUser == null)
                return "Cannot update an existing user with a null user.";
            else
            {
                if (request.UserTypeId == 1 || request.UserTypeId == 2)
                {
                    updatedUser.Email = request.Email;
                    updatedUser.Password = request.Password;
                    updatedUser.UserTypeId = request.UserTypeId;
                    updatedUser.PhoneNumber = request.PhoneNumber;
                    await _DbContext.SaveChangesAsync();
                    return "The user has been updated";
                }
                else { return "The UserType value is incorrect! Values can be either 1 or 2!"; }
            }
        }
}
}
