using MediatR;

namespace Internship.Controllers.Users.Models
{
    public class CreateUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
