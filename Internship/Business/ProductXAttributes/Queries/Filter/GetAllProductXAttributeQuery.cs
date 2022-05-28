using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Queries.Filter
{
    public class GetAllProductXAttributeQuery:IRequest<List<GetAllProductXAttributeResult>>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }

    }
}
