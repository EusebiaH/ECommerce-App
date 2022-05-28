using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Delete
{
    public class DeleteAttributeTypeHandler : IRequestHandler<DeleteAttributeTypeCommand, string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public DeleteAttributeTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteAttributeTypeCommand request, CancellationToken cancellationToken)
        {
            var attributeType = _DbContext.AttributeTypes.FirstOrDefault(x => x.Id == request.Id);

            if (attributeType == null)
                return "The attribute type has not been found.";
            else
            {
                _DbContext.AttributeTypes.Remove(attributeType);
                await _DbContext.SaveChangesAsync();
                return "The attribute type has been deleted.";
            }
        }
    }
}
