
namespace Internship.Controllers.ServiceSchedules.ServiceScheduleModels
{
    public class UpdateServiceScheduleByIdRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
    }
}
