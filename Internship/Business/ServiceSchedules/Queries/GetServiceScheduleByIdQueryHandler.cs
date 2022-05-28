using AutoMapper;
using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using Internship.Data;
using MediatR;

namespace Internship.Business.ServiceSchedules.Queries
{
    public class GetServiceScheduleByIdQueryHandler : IRequestHandler<GetServiceScheduleByIdQuery, GetServiceScheduleByIdResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        public GetServiceScheduleByIdQueryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<GetServiceScheduleByIdResult> Handle(GetServiceScheduleByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _dbContext.ServicesSchedule.FirstOrDefault(s => s.Id == request.Id);
            if (result == null)
                return null;
            else
                return _mapper.Map<GetServiceScheduleByIdResult>(result);
        }
    }
}
