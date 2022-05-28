namespace Internship.Data.Countries.Seed
{
    public class CountryData
    {
        public static IEnumerable<Country> GetData()
        {
            return new[]
            {
                new Country(1){Name="Romania"},
            };
        }
    }
}
