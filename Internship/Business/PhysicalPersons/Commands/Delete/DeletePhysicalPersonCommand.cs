using Internship.Data;
using MediatR;

namespace Internship.Business.PhysicalPersons.Commands.Delete
{
    public class DeletePhysicalPersonCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeletePhysicalPersonCommand(int id)
        {
            Id = id;
        }
    }
}
