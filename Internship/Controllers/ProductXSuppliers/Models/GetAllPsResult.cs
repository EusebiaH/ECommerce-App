namespace Internship.Controllers.ProductXSuppliers.Models
{
    public class GetAllPsResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public double Price { get; set; }

        public string ProductName { get; set; }

        public string SupplierName { get; set; }
    }
}
