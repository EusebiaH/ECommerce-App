namespace Internship.Controllers.Suppliers.Models
{
    public class PostSupplierRequest
    {
        public string Name { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
    }
}
