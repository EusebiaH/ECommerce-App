namespace Internship.Data
{
    public class PhysicalPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
