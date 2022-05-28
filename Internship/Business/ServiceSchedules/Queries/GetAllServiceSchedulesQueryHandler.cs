using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ServiceSchedules.Queries
{
    public class GetAllServiceSchedulesQueryHandler : IRequestHandler<GetAllServiceSchedulesQuery, List<ServiceSchedule>>
    {
        private readonly EcomDbContext _dbContext;
        public GetAllServiceSchedulesQueryHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ServiceSchedule>> Handle(GetAllServiceSchedulesQuery request, CancellationToken cancellationToken)
        {
            var serviceSchedules = await _dbContext.ServicesSchedule.ToListAsync();

            return serviceSchedules;
        }
    }
}
