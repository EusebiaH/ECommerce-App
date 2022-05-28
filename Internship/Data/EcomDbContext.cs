using Microsoft.EntityFrameworkCore;

namespace Internship.Data
{
    public class EcomDbContext : DbContext
    {

        public EcomDbContext(DbContextOptions<EcomDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcomDbContext).Assembly);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PhysicalPerson> PhysicalPersons { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<ProductCategoryXAttribute> ProductCategoryXAttributes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductsType { get; set; }
        public DbSet<ProductXAttribute> ProductXAttributes { get; set; }
        public DbSet<ProductXSupplier> ProductXSuppliers { get; set; }
        public DbSet<ServiceSchedule> ServicesSchedule { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Vat> Vats { get; set; }

    }
}
