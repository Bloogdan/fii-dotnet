using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Badarau_Bogdan_Iosif_Rp.Models;

namespace Asp_Badarau_Bogdan_Iosif_Rp.Data
{
    public class Asp_Badarau_Bogdan_Iosif_RpContext : DbContext
    {
        public Asp_Badarau_Bogdan_Iosif_RpContext (DbContextOptions<Asp_Badarau_Bogdan_Iosif_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Badarau_Bogdan_Iosif_Rp.Models.Movie> Movie { get; set; }
    }
}
