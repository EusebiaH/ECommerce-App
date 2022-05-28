namespace Internship.Controllers.Users.Models
{
    public class GetUserResult
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
