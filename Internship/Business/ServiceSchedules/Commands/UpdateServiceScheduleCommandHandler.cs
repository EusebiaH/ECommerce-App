using AutoMapper;
using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class UpdateServiceScheduleCommandHandler : IRequestHandler<UpdateServiceScheduleCommand, UpdateServiceScheduleByIdResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public UpdateServiceScheduleCommandHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<UpdateServiceScheduleByIdResult> Handle(UpdateServiceScheduleCommand request, CancellationToken cancellationToken)
        {
            var serviceSchedule = await _dbContext.ServicesSchedule.FirstOrDefaultAsync(s => s.Id == request.Id);
            serviceSchedule.ProductId = request.ProductId;
            serviceSchedule.UserId = request.UserId;
            serviceSchedule.Date = request.Date;
            _dbContext.SaveChanges();
            return _mapper.Map<UpdateServiceScheduleByIdResult>(serviceSchedule);
        }
    }
}
