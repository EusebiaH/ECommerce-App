using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Create
{
    public class PostSupplierCommand: IRequest<PostSupplierResult>
    {
        public string Name { get; set; }
        public int AddressId{ get; set; }
        public bool Active { get; set; }

    }
}
