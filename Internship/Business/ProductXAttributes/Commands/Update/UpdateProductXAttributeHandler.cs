using AutoMapper;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Commands.Update
{
    public class UpdateProductXAttributeHandler : IRequestHandler<UpdateProductXAttributeCommand, UpdateProductXAttributeResult>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UpdateProductXAttributeHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<UpdateProductXAttributeResult> Handle(UpdateProductXAttributeCommand request, CancellationToken cancellationToken)
        {
            var productXAtr = _dbContext.ProductXAttributes.FirstOrDefault(x => x.Id == request.Id);

            if (productXAtr == null)
                return null;
            else
            {
                productXAtr = _mapper.Map<ProductXAttribute>(request);
                _dbContext.SaveChangesAsync();
                var result = _mapper.Map<UpdateProductXAttributeResult>(productXAtr);
                return result;
            }
        }
    }
}
