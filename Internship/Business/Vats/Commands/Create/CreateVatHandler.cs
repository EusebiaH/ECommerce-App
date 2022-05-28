using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Vats.Commands.Create
{
    public class CreateVatHandler : IRequestHandler<CreateVatCommand, Vat>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CreateVatHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<Vat> Handle(CreateVatCommand request, CancellationToken cancellationToken)
        {

            var map= _mapper.Map<Vat>(request);
            _dbContext.Vats.Add(map);
            _dbContext.SaveChangesAsync();
            return map;
        }
    }
}
