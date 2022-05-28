using Internship.Controllers.AttributeTypes.Models;
using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Queries.GetAttributeTypeById
{
    public class GetAttributeTypeByIdQuery : IRequest<AttributeTypeResult>
    {
        public int Id { get; set; }

        public GetAttributeTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
