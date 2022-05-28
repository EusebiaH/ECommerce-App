using Internship.Data;
using MediatR;

namespace Internship.Controllers.ProductTypes.Mapping
{
    public class PostProductTypeCommand : IRequest<ProductCategory>
    {
        public string ProductTypeName { get; set; }
        public bool Active { get; set; }

        public PostProductTypeCommand(string name, bool active)
        {
            ProductTypeName = name;
            Active = active;
        }
    }
}