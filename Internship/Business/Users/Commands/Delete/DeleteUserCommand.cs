using MediatR;

namespace Internship.Business.Users.Commands.Delete
{
    public class DeleteUserCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteUserCommand(int id)
        {
            Id = id;
        }
    }
}
