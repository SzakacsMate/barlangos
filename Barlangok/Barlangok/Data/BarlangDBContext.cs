using Barlangok.Models;
using Microsoft.EntityFrameworkCore;

namespace Barlangok.Data
{
    public class BarlangDBContext : DbContext
    {
        public BarlangDBContext(DbContextOptions<BarlangDBContext> options) : base(options)
        {


        }
        public DbSet<Barlang> Barlangok { get; set; }
    }
}
