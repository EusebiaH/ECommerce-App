namespace Internship.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int VATId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vat VAT { get; set; }
    }
}
