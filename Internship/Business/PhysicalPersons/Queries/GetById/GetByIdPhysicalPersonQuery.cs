using Internship.Controllers.PhysicalPersons.Models;
using MediatR;

namespace Internship.Business.PhysicalPersons.Queries.GetById
{
    public class GetByIdPhysicalPersonQuery : IRequest<GetByIdPhysicalPersonResult>
    {
        public int Id { get; set; }

        public GetByIdPhysicalPersonQuery(int id)
        {
            Id = id;
        }
    }
}
