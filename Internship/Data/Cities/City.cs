namespace Internship.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountyId { get; set; }
        public virtual County County { get; set; }

        public City(int id)
        {
            Id = id;
        }
    }
}
