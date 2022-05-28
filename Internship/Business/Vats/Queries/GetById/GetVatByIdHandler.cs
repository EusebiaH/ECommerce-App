using AutoMapper;
using Internship.Data;
using Internship.Data.Vats;
using MediatR;

namespace Internship.Business.Vats.Queries.GetById
{
    public class GetVatByIdHandler : IRequestHandler<GetVatByIdQuery, GetVatByIdResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GetVatByIdHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<GetVatByIdResult> Handle(GetVatByIdQuery request, CancellationToken cancellationToken)
        {
            var vat = new Vat();
            vat = _dbContext.Vats.FirstOrDefault(x=>x.Id==request.Id);
            if (vat == null)
            {
                return null;
            }
            var x= _mapper.Map<GetVatByIdResult>(vat);
            return x;
            
        }
    }
}
