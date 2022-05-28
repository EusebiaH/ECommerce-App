using Internship.Controllers.ProductXSuppliers.Models;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Update
{
    public class UpdatePsCommand: IRequest<UpdatePsResult>
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int NewSupplierId { get; set; }

        public UpdatePsCommand(int productId, int supplierId, int newSupplierId)
        {
            SupplierId = supplierId;
            ProductId = productId;
            NewSupplierId = newSupplierId;
        }
    }
}
