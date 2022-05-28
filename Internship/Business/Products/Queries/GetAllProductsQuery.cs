using Internship.Controllers.Products.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Queries
{
    public class GetAllProductsQuery:IRequest<List<GetProductsResult>>
    {
    }
}
