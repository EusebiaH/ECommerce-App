using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategoryXAttributes.Commands.Create
{
    public class PostProductCategoryXAttributeCommand : IRequest<PostProductCategoryXAttributeResult>
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int AttributeId { get; set; }

        public PostProductCategoryXAttributeCommand(int productCategoryId, int attributeId)
        {
            ProductCategoryId = productCategoryId;
            AttributeId = attributeId;
        }
    }
}
