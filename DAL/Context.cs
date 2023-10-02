using Microsoft.EntityFrameworkCore;
using Yokaira_AP1_P1.Models;

namespace Yokaira_AP1_P1.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Aportes> aporte { get; set; }
    }
}
