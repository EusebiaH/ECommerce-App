using AutoMapper;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategoryXAttributes.Commands.Create
{
    public class PostProductCategoryXAttributeHandler : IRequestHandler<PostProductCategoryXAttributeCommand, PostProductCategoryXAttributeResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public PostProductCategoryXAttributeHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<PostProductCategoryXAttributeResult> Handle(PostProductCategoryXAttributeCommand request, CancellationToken cancellationToken)
        {
            var prodCatXAttributeReq = _mapper.Map<ProductCategoryXAttribute>(request);
            _dbContext.ProductCategoryXAttributes.Add(prodCatXAttributeReq);
            _dbContext.SaveChanges();
            var result = _mapper.Map<PostProductCategoryXAttributeResult>(prodCatXAttributeReq);
            return result;
        }
    }
}
