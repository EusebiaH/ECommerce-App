using Internship.Controllers.ProductXAttributes.Models;
using MediatR;

namespace Internship.Business.ProductXAttributes.Commands.Create
{
    public class CreateProductXAttributeCommand:IRequest<CreateProductXAttributeResult>
    {
        public double Value { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
    }
}
