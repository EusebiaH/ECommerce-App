using MediatR;
using Internship.Data;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class PostProductCategoryCommand : IRequest<ProductCategory>
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public PostProductCategoryCommand(string prodCategory, bool active)
        {
            Name = prodCategory;
            Active = active;
        }
    }
}
