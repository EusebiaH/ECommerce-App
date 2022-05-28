namespace Internship.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public int TotalVATPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int StatusId { get; set; }
        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
        public virtual Status Status { get; set; }
    }
}
