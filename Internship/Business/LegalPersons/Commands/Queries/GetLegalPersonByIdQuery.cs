using Internship.Controllers.LegalPersons.Models;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Queries
{
    public class GetLegalPersonByIdQuery : IRequest<GetLegalPersonByIdResult>
    {
        public int Id { get; set; }
        public GetLegalPersonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
