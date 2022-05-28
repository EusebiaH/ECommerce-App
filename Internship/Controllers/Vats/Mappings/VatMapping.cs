using AutoMapper;
using Internship.Business.Vats.Commands.Create;
using Internship.Business.Vats.Commands.Update;
using Internship.Data;
using Internship.Data.Vats;

namespace Internship.Controllers.Vats.Mappings
{
    public class VatMapping:Profile
    {
        public VatMapping()
        {
            CreateMap<CreateVatCommand,Vat>();
            CreateMap<Vat, GetVatResult>();
            CreateMap<Vat,GetVatByIdResult>();
            CreateMap<UpdateVatCommand, UpdateVatResult>();
            CreateMap<Vat, UpdateVatResult>();

        }
    }
}
