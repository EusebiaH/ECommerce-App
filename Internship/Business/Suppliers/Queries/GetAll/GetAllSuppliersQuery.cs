using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Queries.GetAll
{
    public class GetAllSuppliersQuery : IRequest<Response>
    {
        public int Page { get; set; }
        public double ObjectsOnPage { get; set; }

        public GetAllSuppliersQuery(int page, double objectOnPage)
        {
            Page = page;
            ObjectsOnPage = objectOnPage;
        }
    }

    
}
