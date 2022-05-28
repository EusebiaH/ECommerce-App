using Internship.Controllers.Products.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Commands.Update
{
    public class UpdateProductCommand:IRequest<UpdateProductResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceWithVAT { get; set; }
        public double Discount { get; set; }
        public double PriceDiscount { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public double VATValue { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int VATId { get; set; }
    }
}
