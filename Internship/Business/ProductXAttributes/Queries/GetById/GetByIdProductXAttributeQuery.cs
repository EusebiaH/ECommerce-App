using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Queries.GetById
{
    public class GetByIdProductXAttributeQuery:IRequest<ProductXAttribute>
    {
        public int Id { get; set; }
        public GetByIdProductXAttributeQuery(int id)
        {
            Id = id;
        }
    }
}
