using AutoMapper;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Create
{
    public class PostPsHandler: IRequestHandler<PostPsCommand, PostPsResult>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public PostPsHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PostPsResult> Handle(PostPsCommand request, CancellationToken cancellationToken)
        {
            var ps = _mapper.Map<ProductXSupplier>(request);
            _dbContext.ProductXSuppliers.Add(ps);
            await _dbContext.SaveChangesAsync();
            var psResult = _mapper.Map<PostPsResult>(ps);
            return psResult;
        }


    }
}
