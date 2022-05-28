namespace Internship.Data
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public virtual Address Address { get; set; }
    }
}
