using Internship.Data;

namespace Internship.Business.Suppliers.Queries.GetAll
{
    public class Response
    {
        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
