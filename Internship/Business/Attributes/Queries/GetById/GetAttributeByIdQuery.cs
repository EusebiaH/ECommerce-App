using Internship.Data;
using MediatR;

namespace Internship.Business.Attributes.Queries.GetById
{
    public class GetAttributeByIdQuery : IRequest<GetAttributeById>
    {
        public int Id { get; set; } 
        public GetAttributeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
