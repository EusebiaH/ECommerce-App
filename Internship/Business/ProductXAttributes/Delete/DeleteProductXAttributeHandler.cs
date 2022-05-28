using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Delete
{
    public class DeleteProductXAttributeHandler : IRequestHandler<DeleteProductXAttributeCommand, string>
    {
        public EcomDbContext _dbContext;
        public DeleteProductXAttributeHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> Handle(DeleteProductXAttributeCommand request, CancellationToken cancellationToken)
        {
            var search=_dbContext.ProductXAttributes.FirstOrDefault(x=>x.Id == request.Id);
            if (search == null)
                return null;
            else
                _dbContext.ProductXAttributes.Remove(search);
                _dbContext.SaveChangesAsync();
            return "Deleted";
        }
    }
}
