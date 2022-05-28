using Internship.Controllers.ProductXSuppliers.Models;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Queries.GetAll
{
    public class GetAllPsQuery: IRequest<List<GetAllPsResult>>
    {
    }
}
