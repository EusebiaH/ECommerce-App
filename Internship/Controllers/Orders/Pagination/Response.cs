using Internship.Data;

namespace Internship.Controllers.Orders.Pagination
{
    public class Response
    {
        public List<Order> Orders { get; set; }=new List<Order>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }  
    }
}
