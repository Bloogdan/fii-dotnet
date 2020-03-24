using System.Data.Entity;

namespace EFStudiiDeCaz
{
    public class BusinessContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public BusinessContext() : base("name=BusinessContext")
        { }
    }
}
