using Internship.Data;
using MediatR;

namespace Internship.Business.Products.Commands.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, string>
    {
        public EcomDbContext _dbContext;
        public DeleteProductCommandHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == request.Id);
            if (product == null)
                return null;
            else
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
                return "ok";
            }
                

        }
    }
}
