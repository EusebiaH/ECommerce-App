namespace Internship.Controllers.Stocks.Models
{
    public class GetStockIdResult
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
