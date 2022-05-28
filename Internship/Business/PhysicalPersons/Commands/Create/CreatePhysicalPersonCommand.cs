using Internship.Controllers.PhysicalPersons.Models;
using MediatR;

namespace Internship.Business.PhysicalPersons.Commands.Create
{
    public class CreatePhysicalPersonCommand: IRequest<CreatePhysicalPersonResult>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int UserId { get; set; }
    }
}
