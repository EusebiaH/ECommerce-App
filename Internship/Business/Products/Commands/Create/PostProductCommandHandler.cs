using AutoMapper;
using Internship.Controllers.Products.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Commands.Create
{
    public class PostProductCommandHandler : IRequestHandler<PostProductCommand, PostProductResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public PostProductCommandHandler(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<PostProductResult> Handle(PostProductCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Product>(request);
            if (result == null)
                return null;
            else
            {
                _dbContext.Products.Add(result);
                _dbContext.SaveChanges();
            }
            return _mapper.Map<PostProductResult>(result);
        }
    }
}
