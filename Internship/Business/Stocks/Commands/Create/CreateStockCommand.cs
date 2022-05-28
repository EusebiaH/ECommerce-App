using MediatR;
using Internship.Data;
using Internship.Controllers.Stocks.ModelsStock;

namespace Internship.Business.Stocks.Commands.Create
{
    public class CreateStockCommand: IRequest<StockResult>
    {
        public DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice {get; set; }
    }
}
