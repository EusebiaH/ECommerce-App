namespace Internship.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
