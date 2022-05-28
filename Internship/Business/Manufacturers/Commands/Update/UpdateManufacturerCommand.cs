using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Commands.Update
{
    public class UpdateManufacturerCommand : IRequest<UpdateManufacturerResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadquartersLocation { get; set; }
        public bool Active { get; set; }
    }
}
