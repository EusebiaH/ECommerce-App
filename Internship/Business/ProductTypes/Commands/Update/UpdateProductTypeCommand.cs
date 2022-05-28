using Internship.Controllers.ProductTypes.Models;
using MediatR;

namespace Internship.Business.ProductTypes.Commands.Update
{
    public class UpdateProductTypeCommand:IRequest<UpdateProductTypeResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Activ { get; set; }
    }
}
