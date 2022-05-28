using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Commands.Delete
{
    public class DeleteManufacturerCommand : IRequest<string>
    {
        public int Id { get; set; }
        public DeleteManufacturerCommand(int id)
        {
            Id = id;
        }
    }
}
