using Internship.Controllers.LegalPersons.Models;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Create
{
    public class CreateLegalPersonCommand : IRequest<PostLegalPersonResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CUI { get; set; }
    }
}
