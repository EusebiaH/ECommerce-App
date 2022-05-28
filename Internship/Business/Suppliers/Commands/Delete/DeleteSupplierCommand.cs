using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Delete
{
    public class DeleteSupplierCommand: IRequest<string>
    {
        public string Name { get; set; }

        public DeleteSupplierCommand(string supplierName)
        {
            Name = supplierName;
        }
    }
}
