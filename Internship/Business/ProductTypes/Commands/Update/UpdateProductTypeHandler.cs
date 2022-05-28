using AutoMapper;
using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductTypes.Commands.Update
{
    public class UpdateProductTypeHandler:IRequestHandler<UpdateProductTypeCommand, UpdateProductTypeResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateProductTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UpdateProductTypeResult> Handle(UpdateProductTypeCommand request, CancellationToken cancellationToken)
        {
            var prodType = _dbContext.ProductsType.FirstOrDefault(p => p.Id == request.Id);
            if (prodType == null)
                return null;

            prodType.Name = request.Name;
            prodType.Activ=request.Activ;

            _dbContext.SaveChanges();

            var result = new UpdateProductTypeResult();
            result.Id = request.Id;
            result.Name = prodType.Name;
            result.Activ = prodType.Activ;

            return result;


        }
    }
}
