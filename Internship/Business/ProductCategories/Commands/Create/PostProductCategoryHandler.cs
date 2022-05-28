using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class PostProductCategoryHandler : IRequestHandler<PostProductCategoryCommand, ProductCategory>
    {
        private readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public PostProductCategoryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public async Task<ProductCategory> Handle(PostProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var prod = _dbContext.ProductCategorys.Where(x => x.Name == request.Name).FirstOrDefault();
            if (prod == null)
            {
                var productCategory = _mapper.Map<ProductCategory>(request);
                _dbContext.ProductCategorys.Add(productCategory);
                _dbContext.SaveChanges();
                return productCategory;
            }
            return (prod);
        }
    }
}
