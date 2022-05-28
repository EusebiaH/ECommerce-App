using Internship.Data;

namespace Internship.Controllers.Stocks.Pagination
{
    public class StockPaginationResponse
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
