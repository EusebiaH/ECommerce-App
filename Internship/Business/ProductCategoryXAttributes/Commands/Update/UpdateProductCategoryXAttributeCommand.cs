using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategoryXAttributes.Commands.Update
{
    public class UpdateProductCategoryXAttributeCommand : IRequest<UpdateProductCategoryXAttributeResult>
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int AttributeId { get; set; }
    }
}
