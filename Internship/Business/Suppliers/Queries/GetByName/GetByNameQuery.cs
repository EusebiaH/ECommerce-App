using Internship.Controllers.Suppliers.Models;
using MediatR;

namespace Internship.Business.Suppliers.Queries.GetByName
{
    public class GetByNameQuery: IRequest<GetByNameResult>
    {
        public string Name { get; set; }
    }
}
