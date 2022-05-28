using Internship.Controllers.Users.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Users.Queries.Filter
{
    public class GetAllUsersQuery : IRequest<List<GetUserResult>>
    {
        
    }
}
