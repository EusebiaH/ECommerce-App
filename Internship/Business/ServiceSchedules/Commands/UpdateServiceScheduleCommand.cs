using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using MediatR;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class UpdateServiceScheduleCommand:IRequest<UpdateServiceScheduleByIdResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
    }
}
