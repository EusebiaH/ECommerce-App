using AutoMapper;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategoryXAttributes.Commands.Update
{
    public class UpdateProductCategoryXAttributeHandler : IRequestHandler<UpdateProductCategoryXAttributeCommand, UpdateProductCategoryXAttributeResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public UpdateProductCategoryXAttributeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



        public async Task<UpdateProductCategoryXAttributeResult> Handle(UpdateProductCategoryXAttributeCommand request, CancellationToken cancellationToken)
        {
            var UpdProdCatXAtt = await _dbContext.ProductCategoryXAttributes.Include(x => x.Attribute)
                                                    .Include(p => p.ProductCategory).Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (UpdProdCatXAtt == null)
                return null;
            else
            {
                UpdProdCatXAtt.ProductCategoryId = request.ProductCategoryId;
                UpdProdCatXAtt.AttributeId = request.AttributeId;
                _dbContext.SaveChanges();
                var updatecopy = new UpdateProductCategoryXAttributeResult();
                updatecopy.Id=request.Id;
                updatecopy.ProductCategoryId = UpdProdCatXAtt.ProductCategoryId;
                updatecopy.AttributeId = UpdProdCatXAtt.AttributeId;
                return updatecopy;

            }
        }
    }
}
