namespace Internship.Data
{
    public class Address
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CountryId { get; set; }

        public int CountyId { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public string OtherDetails { get; set; }

        public virtual User User { get; set; }

        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public virtual County County { get; set; }

    }
}
