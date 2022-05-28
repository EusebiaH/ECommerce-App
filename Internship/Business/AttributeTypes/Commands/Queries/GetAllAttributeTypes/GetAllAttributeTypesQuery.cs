using Internship.Controllers.AttributeTypes.Models;
using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Queries.GetAllAttributeTypes
{
    public class GetAllAttributeTypesQuery : IRequest<List<AttributeTypeResult>>
    {

    }
    
}
