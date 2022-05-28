using AutoMapper;
using Internship.Business.OrderDetails.Commands.Create;
using Internship.Controllers.OrderDetails.Models;
using Internship.Data;

namespace Internship.Controllers.OrderDetails.Mappings
{
    public class OrderDetailMapping : Profile
    {
        public OrderDetailMapping()
        {
            CreateMap<PostOrderDetailRequest, CreateOrderDetailCommand>();
            CreateMap<CreateOrderDetailCommand, OrderDetail>();
            CreateMap<OrderDetail, PostOrderDetailResult>();

            CreateMap<OrderDetail, GetOrderDetailByIdResult>();


        }
    }
}
