using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Commands.Create
{
    public class CreateManufacturerCommand : IRequest<CreateManufacturerResult>
    {
        public string Name { get; set; }
        public string HeadquartersLocation { get; set; }
        public bool Active { get; set; }
    }
}
