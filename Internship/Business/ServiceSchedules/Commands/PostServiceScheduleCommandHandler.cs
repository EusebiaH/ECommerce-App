using AutoMapper;
using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using Internship.Data;
using MediatR;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class PostServiceScheduleCommandHandler : IRequestHandler<PostServiceScheduleCommand, PostServiceScheduleResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        
        public PostServiceScheduleCommandHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<PostServiceScheduleResult> Handle(PostServiceScheduleCommand request, CancellationToken cancellationToken)
        {
            var serviceSchedule = _mapper.Map<ServiceSchedule>(request);
            _dbContext.Add(serviceSchedule);
            _dbContext.SaveChanges();
            return _mapper.Map<PostServiceScheduleResult>(serviceSchedule);
        }
    }
}
