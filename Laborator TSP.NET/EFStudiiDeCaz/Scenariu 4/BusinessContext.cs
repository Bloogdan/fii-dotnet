using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiiDeCaz
{
    public class BusinessContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public BusinessContext() : base("name=BusinessContext")
        { }
    }
}
