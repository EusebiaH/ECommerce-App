using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using MediatR;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class PostServiceScheduleCommand:IRequest<PostServiceScheduleResult>
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
    }
}
