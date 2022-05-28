namespace Internship.Controllers.PhysicalPersons.Models
{
    public class PutPhysicalPersonRequest
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int UserId { get; set; }
    }
}
