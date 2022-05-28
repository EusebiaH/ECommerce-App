using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Manufacturers.Commands.Delete
{
    public class DeleteManufacturerHandler : IRequestHandler<DeleteManufacturerCommand, string>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeleteManufacturerHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(DeleteManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturer = await _dbContext.Manufacturers.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (manufacturer != null)
            {
                _dbContext.Manufacturers.Remove(manufacturer);
                await _dbContext.SaveChangesAsync();
                return "Manufacturer with Name = " + manufacturer.Name + " Deleted";
            }
            return "Manufacturer doesn't exist";
        }
    }
}
