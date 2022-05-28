using Internship.Data;
using MediatR;

namespace Internship.Business.ProductTypes.Commands.Create
{
    public class CreateProductTypeCommand : IRequest<ProductType>
    {
        public string Name { get; set; }
        public bool Activ { get; set; }

    }
}
