namespace Internship.Controllers.OrderDetails.Models
{
    public class PostOrderDetailRequest
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int VATId { get; set; }
    }
}
