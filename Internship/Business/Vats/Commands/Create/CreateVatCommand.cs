using Internship.Data;
using Internship.Data.Vats;
using MediatR;

namespace Internship.Business.Vats.Commands.Create
{
    public class CreateVatCommand:IRequest<Vat>
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
