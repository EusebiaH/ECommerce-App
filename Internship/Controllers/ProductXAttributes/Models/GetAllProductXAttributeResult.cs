namespace Internship.Controllers.ProductXAttributes.Models
{
    public class GetAllProductXAttributeResult
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductCategoryName { get; set; }
        public string ManufracturerName { get; set; }
        public string VatName { get; set; }

    }
}
