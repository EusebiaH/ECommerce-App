using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.AttributeTypes.Commands.Create
{
    public class CreateNewAttributeTypeHandler : IRequestHandler<CreateNewAttributeTypeCommand,string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public CreateNewAttributeTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> Handle(CreateNewAttributeTypeCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return "Cannot insert an attribute type that is null.";
            else
            {
                    var CreateAttributeType = _mapper.Map<AttributeType>(request);
                    _DbContext.AttributeTypes.Add(CreateAttributeType);
                    await _DbContext.SaveChangesAsync();
                    return "The attribute type has been created.";
            }
        }
    }
}
