namespace Internship.Controllers.Manufacturers.Models
{
    public class PutManufacturerRequest
    {
        public string Name { get; set; }
        public string HeadquartersLocation { get; set; }
        public bool Active { get; set; }
    }
}
