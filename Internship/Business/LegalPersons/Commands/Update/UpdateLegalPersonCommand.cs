using Internship.Controllers.LegalPersons.Models;
using MediatR;

namespace Internship.Business.LegalPersons.Commands.Update
{
    public class UpdateLegalPersonCommand:IRequest<UpdateLegalPersonResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CUI { get; set; }
    }
}
