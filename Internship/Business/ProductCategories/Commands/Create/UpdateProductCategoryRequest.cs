using MediatR;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class UpdateProductCategoryRequest : IRequest<UpdateProductCategoryResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
