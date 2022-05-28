using Internship.Controllers.OrderDetails.Models;
using MediatR;

namespace Internship.Business.OrderDetails.Commands.Create
{
    public class CreateOrderDetailCommand:IRequest<PostOrderDetailResult>
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int VATId { get; set; }
    }
}
