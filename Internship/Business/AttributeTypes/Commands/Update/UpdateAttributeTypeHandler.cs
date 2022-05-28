using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.AttributeTypes.Commands.Update
{
    public class UpdateAttributeTypeHandler : IRequestHandler<UpdateAttributeTypeCommand, string>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public UpdateAttributeTypeHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(UpdateAttributeTypeCommand request, CancellationToken cancellationToken)
        {
            var updatedAttributeType = await _DbContext.AttributeTypes.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (updatedAttributeType == null)
                return "Cannot update an existing attribute type with a null value.";
            else
            {
                    updatedAttributeType.Name = request.Name;
                    await _DbContext.SaveChangesAsync();
                    return "The attribute type has been updated"; 
            }
        }
    }
}
