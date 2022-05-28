using Internship.Data;
using MediatR;

namespace Internship.Business.Orders.Queries
{
    public class GetAllOrdersByIdQuery: IRequest<Order>
    {
        public int Id { get; set; }  

        public GetAllOrdersByIdQuery(int id)
        {
            Id = id;    
        }



    }
}
