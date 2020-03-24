using Microsoft.EntityFrameworkCore;

namespace ModelCodeFirst
{
    internal class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=BOGDANLAPTOP\SQLEXPRESS;Initial Catalog=TestPerson;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany<Order>(o => o.Orders)
                .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetails>()
                .HasOne<Order>(od => od.Order)
                .WithMany(o => o.OrderDetails);
            modelBuilder.Entity<Product>()
                .HasMany<OrderDetails>(p => p.OrderDetails)
                .WithOne(od => od.Product);
        }
    }
}
