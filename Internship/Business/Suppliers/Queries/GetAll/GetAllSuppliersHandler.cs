using AutoMapper;
using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Suppliers.Queries.GetAll
{
    public class GetAllSuppliersHandler : IRequestHandler<GetAllSuppliersQuery, Response>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public GetAllSuppliersHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAllSuppliersQuery request, CancellationToken cancellationToken)
        {
         
            var pageResults = request.ObjectsOnPage;
            var pageCount = Math.Ceiling(_dbContext.Suppliers.Count() / pageResults);

            var suppliers = await _dbContext.Suppliers.Skip((request.Page - 1) * (int)pageResults).Take((int)pageResults).ToListAsync();

            var response = new Response
            {
                Suppliers = suppliers,
                CurrentPage = request.Page,
                Pages = (int)pageCount
            };

            return response;
        }
    }
}
