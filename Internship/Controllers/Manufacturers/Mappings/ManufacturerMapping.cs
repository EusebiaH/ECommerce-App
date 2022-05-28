using AutoMapper;
using Internship.Business.Manufacturers.Commands.Create;
using Internship.Business.Manufacturers.Commands.Delete;
using Internship.Business.Manufacturers.Commands.Update;
using Internship.Business.Manufacturers.Queries.Filter;
using Internship.Business.Manufacturers.Queries.GetById;
using Internship.Controllers.Manufacturers.Models;
using Internship.Data;

namespace Internship.Controllers.Manufacturers
{
    public class ManufacturerMapping: Profile
    {
        public ManufacturerMapping()
        {
            CreateMap<GetManufacturerByIdQuery, Manufacturer>();

            CreateMap<PostManufacturerRequest, CreateManufacturerCommand>();

            CreateMap<UpdateManufacturerRequest, UpdateManufacturerCommand>();

            CreateMap<PutManufacturerRequest, UpdateManufacturerCommand>();

            CreateMap<ManufacturerRequest, DeleteManufacturerCommand>();

            CreateMap<Manufacturer, GetManufacturerIdResult>();

            CreateMap<Manufacturer, DeleteManufacturerCommand>();

            CreateMap<Manufacturer, CreateManufacturerCommand>();

            CreateMap<CreateManufacturerCommand, ManufacturerResult>();

            CreateMap<CreateManufacturerCommand, Manufacturer>();

            CreateMap<Manufacturer, UpdateManufacturerCommand>();

            CreateMap<Manufacturer, GetAllManufacturerQuery>();

            CreateMap<Manufacturer, CreateManufacturerResult>();

            CreateMap<Manufacturer, UpdateManufacturerResult>();
        }
    }
}
