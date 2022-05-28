using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Users.Commands.Delete
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public DeleteUserHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = _DbContext.Users.FirstOrDefault(x => x.Id == request.Id);

            if (user == null)
                return "The person has not been found.";
            else
            {
                _DbContext.Users.Remove(user);
                await _DbContext.SaveChangesAsync();
                return "The person has been deleted.";
            }
        }
    }
}
