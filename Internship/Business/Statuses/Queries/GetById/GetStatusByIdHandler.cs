using AutoMapper;
using Internship.Data;
using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Queries.GetById
{
    public class GetStatusByIdHandler : IRequestHandler<GetStatusByIdQuery, GetStatusByIdResult>
    {

        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GetStatusByIdHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<GetStatusByIdResult> Handle(GetStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var status = new Status();
            status = _dbContext.Statuses.FirstOrDefault(x => x.Id == request.Id);
            if (status == null)
            {
                return null;
            }
            var x = _mapper.Map<GetStatusByIdResult>(status);
            return x;
        }
    }
}
