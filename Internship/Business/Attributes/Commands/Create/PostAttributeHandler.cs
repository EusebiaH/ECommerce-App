using AutoMapper;
using Internship.Data;
using MediatR;

namespace Internship.Business.Attributes.Commands.Create
{
    public class PostProductCategoryHandler : IRequestHandler<PostAttributeCommand, Data.Attribute>
    {
        private readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public PostProductCategoryHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public async Task<Data.Attribute> Handle(PostAttributeCommand request, CancellationToken cancellationToken)
        {
            var att=_dbContext.Attributes.Where(x=>x.Name == request.Name).FirstOrDefault();
            
            if (att == null)
            {
                var attributereq=_mapper.Map<Data.Attribute>(request);
                _dbContext.Attributes.Add(attributereq);
                _dbContext.SaveChanges();
                return attributereq;
            }
            return (att);
        }
    }
}
