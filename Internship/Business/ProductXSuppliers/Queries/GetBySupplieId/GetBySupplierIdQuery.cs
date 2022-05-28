using Internship.Controllers.ProductXSuppliers.Models;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Queries.GetBySupplieId
{
    public class GetBySupplierIdQuery: IRequest<List<GetBySupplierIdResult>>
    {
        public int SupplierId { get; set; }

        public GetBySupplierIdQuery(int supplierId)
        {
            SupplierId = supplierId;
        }
    }
}
