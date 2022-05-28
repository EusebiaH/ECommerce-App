﻿using Internship.Controllers;
using MediatR;

namespace Internship.Business.Orders.Commands.Update
{
    public class UpdateOrderCommand: IRequest<UpdateOrderResult>
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public int TotalVATPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int StatusId { get; set; }
    }
}
