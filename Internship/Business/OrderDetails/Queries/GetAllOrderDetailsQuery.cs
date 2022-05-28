using Internship.Data;
using MediatR;

namespace Internship.Business.OrderDetails.Queries
{
    public class GetAllOrderDetailsQuery : IRequest<List<OrderDetail>>
    {
    }
}
