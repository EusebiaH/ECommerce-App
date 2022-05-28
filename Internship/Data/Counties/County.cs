 
namespace Internship.Data
{
    public class County
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public County(int id)
        {
            Id = id;
        }
    }
}
