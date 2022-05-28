namespace Internship.Controllers.Suppliers.Models
{
    public class PostSupplierResult
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AddressId{ get; set; }
        public bool Active { get; set; }
    }
}
