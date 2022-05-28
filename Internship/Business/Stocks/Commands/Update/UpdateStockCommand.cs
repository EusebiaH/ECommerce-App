using MediatR;
using Internship.Controllers.Stocks.ModelsStock;

namespace Internship.Business.Stocks.Commands.Update
{
    public class UpdateStockCommand : IRequest<StockResult>
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
    }
}
