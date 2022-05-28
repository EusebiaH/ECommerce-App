using Internship.Controllers.Users.Models;
using MediatR;

namespace Internship.Business.Users.Queries.GetById
{
    public class GetUserByIdQuery : IRequest<GetUserResult>
    {
        public int Id;

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
