using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class UpdateProductCategoryHandler : IRequestHandler<UpdateProductCategoryRequest, UpdateProductCategoryResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public UpdateProductCategoryHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<UpdateProductCategoryResult> Handle(UpdateProductCategoryRequest request, CancellationToken cancellationToken)
        {
            var prodCat = await _dbContext.ProductCategorys.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (prodCat == null)
                return null;
            else
            {
                prodCat.Name = request.Name;
                prodCat.Active = request.Active;

                _dbContext.SaveChanges();

                var result = new UpdateProductCategoryResult();
                var req = _mapper.Map<UpdateProductCategoryResult>(request);
                return req;
            }
        }
    }
}
