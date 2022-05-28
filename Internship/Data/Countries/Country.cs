namespace Internship.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country(int id)
        {
            Id = id;
        }
    }
}
