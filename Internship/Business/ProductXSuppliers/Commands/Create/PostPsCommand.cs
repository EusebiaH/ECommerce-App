using Internship.Controllers.ProductXSuppliers.Models;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Create
{
    public class PostPsCommand: IRequest<PostPsResult>
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public double Price { get; set; }

        public PostPsCommand(int productId, int supplierId, double price)
        {
           ProductId = productId;
           SupplierId = supplierId;
           Price = price;
        }
    }
}
