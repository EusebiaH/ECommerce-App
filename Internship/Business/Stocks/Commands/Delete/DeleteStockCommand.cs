using Internship.Data;
using MediatR;

namespace Internship.Business.Stocks.Commands.Delete
{
    public class DeleteStockCommand:IRequest<Stock>
    {
        public int Id { get; set; }
        public DeleteStockCommand(int id)
        {
            Id = id;
        }
    }
}
