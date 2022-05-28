using MediatR;

namespace Internship.Business.Users.Commands.Create
{
    public class CreateUserCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
