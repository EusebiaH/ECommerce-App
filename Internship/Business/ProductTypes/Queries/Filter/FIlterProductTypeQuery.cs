using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductTypes.Queries.Filter
{
    public class FIlterProductTypeQuery : IRequest<List<GetAllProductTypeResult>>
    {
    }
}

