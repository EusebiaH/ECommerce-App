using AutoMapper;
using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Commands.Create
{
    public class CreateManufacturerHandler : IRequestHandler<CreateManufacturerCommand, CreateManufacturerResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateManufacturerHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<CreateManufacturerResult> Handle(CreateManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturer = _mapper.Map<Manufacturer>(request);
            _dbContext.Manufacturers.Add(manufacturer);
            await _dbContext.SaveChangesAsync();
            var newManufacturer = _mapper.Map<CreateManufacturerResult>(manufacturer);
            return newManufacturer;
        }

    }
}
