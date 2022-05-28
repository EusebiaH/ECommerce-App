using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Attributes.Commands.Update
{
    public class UpdateAttributeHandler : IRequestHandler<UpdateAttributeCommand, UpdateAttributeResult>
    {
        private readonly IMapper _mapper;
        private readonly EcomDbContext _dbContext;

        public UpdateAttributeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public async Task<UpdateAttributeResult> Handle(UpdateAttributeCommand request, CancellationToken cancellationToken)
        {
            var att = await _dbContext.Attributes.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (att == null)
                return null;
            else
            {
                att.Name = request.Name;
                att.Active=request.Active;
                //att.AttributeTypeId= request.AttributeTypeId;
                _dbContext.SaveChanges();
                var result = new UpdateAttributeResult();
                var req = _mapper.Map<UpdateAttributeResult>(request);
                return req;
            }
        }
    }
}
