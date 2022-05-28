namespace Internship.Controllers.Stocks.ModelsStock
{
    public class StockRequest
    {
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
