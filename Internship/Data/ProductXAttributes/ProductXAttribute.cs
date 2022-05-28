namespace Internship.Data
{
    public class ProductXAttribute
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int AttributeId { get; set; }
        public virtual Attribute? Attribute { get; set; }
        public double Value { get; set; }

    }
}
