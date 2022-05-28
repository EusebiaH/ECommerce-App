using AutoMapper;
using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Queries.GetById
{
    public class GetManufacturerByIdHandler : IRequestHandler<GetManufacturerByIdQuery, GetManufacturerIdResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetManufacturerByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetManufacturerIdResult> Handle(GetManufacturerByIdQuery request, CancellationToken cancellationToken)
        {
            var items = _dbContext.Manufacturers.Where(x => x.Id == request.Id).FirstOrDefault();
            var itemsCopy = _mapper.Map<GetManufacturerIdResult>(items);
            return itemsCopy;
        }
    }
}
