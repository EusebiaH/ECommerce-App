using Internship.Data;

namespace Internship.Controllers.Users.Pagination
{
    public class Response
    {
        public List<User> Users { get; set; }=new List<User>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }

    }
}
