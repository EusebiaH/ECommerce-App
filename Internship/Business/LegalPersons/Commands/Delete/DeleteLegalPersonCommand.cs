using MediatR;

namespace Internship.Business.LegalPersons.Commands.Delete
{
    public class DeleteLegalPersonCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteLegalPersonCommand(int id)
        {
            Id = id;
        }
    }
}
