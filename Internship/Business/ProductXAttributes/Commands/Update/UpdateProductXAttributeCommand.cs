using Internship.Controllers.ProductXAttributes.Models;
using MediatR;

namespace Internship.Business.ProductXAttributes.Commands.Update
{
    public class UpdateProductXAttributeCommand:IRequest<UpdateProductXAttributeResult>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public double Value { get; set; }
    }
}
