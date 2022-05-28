using AutoMapper;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Delete
{
    public class DeletePsHandler: IRequestHandler<DeletePsCommand, DeletePsResult>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public DeletePsHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        
        public async Task<DeletePsResult> Handle(DeletePsCommand request, CancellationToken cancellationToken)
        {
            var ps = _dbContext.ProductXSuppliers.FirstOrDefault(x => x.ProductId == request.ProductId && x.SupplierId == request.SupplierId);
            var psResult = _mapper.Map<DeletePsResult>(ps);
            _dbContext.ProductXSuppliers.Remove(ps);
            _dbContext.SaveChanges();
            
            //var psList = _dbContext.ProductXSuppliers.ToListAsync();
            //var psListResult = _mapper.Map<List<GetAllPsResult>>(psList);
            return psResult;
        }
    }
}
