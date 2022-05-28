using AutoMapper;
using Internship.Controllers.Products.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<UpdateProductResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == request.Id);

            if (product == null)
                return null;
            else
            {
                product = _mapper.Map<Product>(request);
                _dbContext.SaveChanges();
                var result =  _mapper.Map<UpdateProductResult>(product);
                return  result;
            }    
        }
    }
}
