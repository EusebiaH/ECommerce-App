namespace Internship.Controllers.OrderDetails.Models
{
    public class PostOrderDetailResult
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int VATId { get; set; }
    }
}
