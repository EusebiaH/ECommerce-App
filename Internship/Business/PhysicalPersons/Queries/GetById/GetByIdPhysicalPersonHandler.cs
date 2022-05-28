using AutoMapper;
using Internship.Controllers.PhysicalPersons.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.PhysicalPersons.Queries.GetById
{
    public class GetStockByIdHandler : IRequestHandler<GetByIdPhysicalPersonQuery, GetByIdPhysicalPersonResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetStockByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetByIdPhysicalPersonResult> Handle(GetByIdPhysicalPersonQuery request, CancellationToken cancellationToken)
        {
            var items = _dbContext.PhysicalPersons.Where(x => x.Id == request.Id).Include(x => x.User).FirstOrDefault();
            var itemsCopy = _mapper.Map<GetByIdPhysicalPersonResult>(items);
            return itemsCopy;
        }
    }
}
