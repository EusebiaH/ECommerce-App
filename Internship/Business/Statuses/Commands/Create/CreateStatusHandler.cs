using AutoMapper;
using Internship.Data;
using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Commands.Create
{
    public class CreateStatusHandler : IRequestHandler<CreateStatusCommand, StatusResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;
        public CreateStatusHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public async Task<StatusResult> Handle(CreateStatusCommand request, CancellationToken cancellationToken)
        {
            var map = _mapper.Map<Status>(request);
            _dbContext.Statuses.Add(map);
            _dbContext.SaveChanges();
            var result = _mapper.Map<StatusResult>(map);
            return result;
        }

      
    }
}
