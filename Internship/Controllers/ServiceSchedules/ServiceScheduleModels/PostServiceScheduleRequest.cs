namespace Internship.Controllers.ServiceSchedules.ServiceScheduleModels
{
    public class PostServiceScheduleRequest
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
    }
}
