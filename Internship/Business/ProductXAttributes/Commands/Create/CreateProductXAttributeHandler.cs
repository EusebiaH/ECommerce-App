using AutoMapper;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Commands.Create
{
    public class CreateProductXAttributeHandler:IRequestHandler<CreateProductXAttributeCommand,CreateProductXAttributeResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CreateProductXAttributeHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CreateProductXAttributeResult> Handle(CreateProductXAttributeCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<ProductXAttribute>(request);
            if (result == null)
                return null;
            else
            {
                _dbContext.ProductXAttributes.Add(result);
                _dbContext.SaveChangesAsync();
            }
            var x=_mapper.Map<CreateProductXAttributeResult>(result);
            return x;
        }
    }
}
