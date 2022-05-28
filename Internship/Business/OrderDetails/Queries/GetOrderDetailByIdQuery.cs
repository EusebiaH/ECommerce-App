using Internship.Controllers.OrderDetails.Models;
using MediatR;

namespace Internship.Business.OrderDetails.Queries
{
    public class GetOrderDetailByIdQuery:IRequest<GetOrderDetailByIdResult>
    {
        public int Id { get; set; }
       public GetOrderDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
