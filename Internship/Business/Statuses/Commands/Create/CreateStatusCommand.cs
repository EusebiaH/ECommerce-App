using Internship.Data;
using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Commands.Create
{
    public class CreateStatusCommand: IRequest<StatusResult>
    {
        public string Name { get; set; }
    }
}
