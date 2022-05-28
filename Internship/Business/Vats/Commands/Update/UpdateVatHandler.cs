using AutoMapper;
using Internship.Data;
using Internship.Data.Vats;
using MediatR;

namespace Internship.Business.Vats.Commands.Update
{
    public class UpdateVatHandler : IRequestHandler<UpdateVatCommand, UpdateVatResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UpdateVatHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<UpdateVatResult> Handle(UpdateVatCommand request, CancellationToken cancellationToken)
        {
            var x = _dbContext.Vats.FirstOrDefault(p => p.Id == request.Id);

            if (x == null)
                return null;

            x.Name = request.Name;
            x.Value = request.Value;

            _dbContext.SaveChangesAsync();
            var result = new UpdateVatResult();
            var res = _mapper.Map<UpdateVatResult>(request);
            return res;

        }
    }
}
