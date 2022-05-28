namespace Internship.Data.Cities.Seed
{
    public class CityData
    {
        public static IEnumerable<City> GetData()
        {
            return new[]
            {
                new City(1){Name="Bucuresti", CountyId = 2},
                new City(2){Name="Pitesti", CountyId = 1},
                new City(3){Name="Chiajna", CountyId = 2},
                new City(4){Name="Targoviste", CountyId = 1},
                new City(5){Name="Iasi", CountyId = 3},
            };
        }
    }
}
