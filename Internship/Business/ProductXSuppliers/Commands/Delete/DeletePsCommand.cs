using Internship.Controllers.ProductXSuppliers.Models;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Delete
{
    public class DeletePsCommand: IRequest<DeletePsResult>
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        public DeletePsCommand(int productId, int supplierId)
        {
            ProductId = productId;
            SupplierId = supplierId;
        }
    }
}
