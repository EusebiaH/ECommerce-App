using AutoMapper;
using Internship.Data;
using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Commands.Update
{
    public class UpdateStatusHandler : IRequestHandler<UpdateStatusCommand, StatusResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        public UpdateStatusHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<StatusResult> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
        {
            var x = _dbContext.Statuses.FirstOrDefault(p => p.Id == request.Id);
            if (x == null)
                return null;
            
                x.Name = request.Name;

                var map=_mapper.Map<StatusResult>(x);
                _dbContext.SaveChanges();
                return map;
            

        }
    }
}
