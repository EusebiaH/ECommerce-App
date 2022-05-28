using AutoMapper;
using Internship.Business.Orders.Commands.Create;
using Internship.Business.Orders.Commands.Update;
using Internship.Data;

namespace Internship.Controllers
{
    public class OrderMapping : Profile
    {

        public OrderMapping()
        {
            CreateMap<PostOrderRequest, PostOrderCommand>();
            CreateMap<PostOrderCommand, Order>();
            CreateMap<Order, PostOrderResult>();
            CreateMap<UpdateOrderRequest, UpdateOrderCommand>();
            CreateMap<UpdateOrderCommand, Order>();
            CreateMap<Order, UpdateOrderResult>(); 

        }


    }
}
