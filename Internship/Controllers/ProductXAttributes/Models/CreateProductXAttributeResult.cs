namespace Internship.Controllers.ProductXAttributes.Models
{
    public class CreateProductXAttributeResult
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
    }
}
