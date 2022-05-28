namespace Internship.Controllers.Stocks.ModelsStock
{
    public class StockResult
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
