using Internship.Controllers.PhysicalPersons.Models;
using MediatR;

namespace Internship.Business.PhysicalPersons.Commands.Update
{
    public class UpdatePhysicalPersonCommand: IRequest<UpdatePhysicalPersonResult>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int UserId { get; set; }
    }
}
