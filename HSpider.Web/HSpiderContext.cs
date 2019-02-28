using Microsoft.EntityFrameworkCore;

using HSpider.Web.Models;

namespace HSpider.Web
{
    public class HSpiderContext : DbContext
    {
        public HSpiderContext(DbContextOptions<HSpiderContext> options) : base(options)
        {

        }

        public DbSet<Comic> Comic { get; set; }
    }
}
