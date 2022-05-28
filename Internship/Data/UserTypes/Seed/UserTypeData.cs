namespace Internship.Data
{
    public class UserTypeData
    {
            public static IEnumerable<UserType> GetData()
            {
                return new[]
                {
                new UserType(1){Name="Physical Person"},
                new UserType(2){Name="Legal Person"}
                };
            }
     }
}
