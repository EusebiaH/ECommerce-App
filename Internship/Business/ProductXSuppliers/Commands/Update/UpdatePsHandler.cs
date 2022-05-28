using AutoMapper;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXSuppliers.Commands.Update
{
    public class UpdatePsHandler: IRequestHandler<UpdatePsCommand, UpdatePsResult>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public UpdatePsHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UpdatePsResult> Handle(UpdatePsCommand request, CancellationToken cancellationToken)
        {
            var ps = _dbContext.ProductXSuppliers.FirstOrDefault(x => x.ProductId == request.ProductId && x.SupplierId == request.SupplierId);
            ps.SupplierId = request.NewSupplierId;
            _dbContext.SaveChanges();

            var psResult = _mapper.Map<UpdatePsResult>(ps);
            return psResult;
        }
        
    }
}
