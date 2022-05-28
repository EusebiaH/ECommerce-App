namespace Internship.Data.Counties.Seed
{
    public class CountyData
    {
        public static IEnumerable<County> GetData()
        {
            return new[]
            {
                new County(1){Name="Arges", CountryId=1},
                new County(2){Name="Bucuresti",CountryId=1},
                new County(3){Name="Iasi",CountryId=1}
            };
        }
    }
}
