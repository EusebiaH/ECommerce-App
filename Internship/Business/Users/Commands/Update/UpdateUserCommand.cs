using Internship.Controllers.Users.Models;
using MediatR;

namespace Internship.Business.Users.Commands.Update
{
    public class UpdateUserCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public UpdateUserCommand(int id, UpdateUserResult UserToUpdate)
        {
            Id = id;
            Email = UserToUpdate.Email;
            Password = UserToUpdate.Password;
            UserTypeId = UserToUpdate.UserTypeId;
            PhoneNumber = UserToUpdate.PhoneNumber;
        }
    }
}
