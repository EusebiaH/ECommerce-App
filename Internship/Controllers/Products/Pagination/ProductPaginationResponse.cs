
using Internship.Data;

namespace Internship.Controllers.Products.Pagination
{
    public class ProductPaginationResponse
    {
        public List<Product> Products { get; set; }=new List<Product>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
