using Internship.Data;
using MediatR;

namespace Internship.Business.PhysicalPersons.Queries.Filter
{
    public class GetAllPhysicalPersonQuery : IRequest<List<PhysicalPerson>>
    {
    }
}
