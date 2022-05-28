using AutoMapper;
using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Commands.Update
{
    public class UpdateManufacturerHandler : IRequestHandler<UpdateManufacturerCommand, UpdateManufacturerResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateManufacturerHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<UpdateManufacturerResult> Handle(UpdateManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturer = _dbContext.Manufacturers.FirstOrDefault(x => x.Id == request.Id);
            if (manufacturer == null)
            {

                return null;
            }
            manufacturer.Active = request.Active;
            manufacturer.Name = request.Name;   
            manufacturer.HeadquartersLocation = request.HeadquartersLocation;

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<UpdateManufacturerResult>(manufacturer);

        }

    }
}
