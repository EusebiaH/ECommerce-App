using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Commands.Update
{
    public class UpdateStatusCommand:IRequest<StatusResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
