namespace Internship.Data
{
    public class ProductCategoryXAttribute
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int AttributeId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
