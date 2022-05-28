using Internship.Data.Vats;
using MediatR;

namespace Internship.Business.Vats.Commands.Update
{
    public class UpdateVatCommand:IRequest<UpdateVatResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

    }
}
