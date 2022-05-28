using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class ServiceScheduleDeleteCommandHandler : IRequestHandler<ServiceScheduleDeleteCommand, string>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public ServiceScheduleDeleteCommandHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(ServiceScheduleDeleteCommand request, CancellationToken cancellationToken)
        {
            var serviceSchedule = _dbContext.ServicesSchedule.FirstOrDefault(s => s.Id == request.Id);
            _dbContext.ServicesSchedule.Remove(serviceSchedule);
            _dbContext.SaveChanges();
            return ("Object deleted");
        }
    }
}
