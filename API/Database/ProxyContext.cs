using Microsoft.EntityFrameworkCore;
using HerstAPI.Models;

namespace HerstAPI.Database
{
    public class HerstDbContext : DbContext
     {
        public DbSet<Proxy> Proxies { get; set; }
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<WiFiProbe> WiFiProbes { get; set; }
        
        internal HerstDbContext(){}
        public HerstDbContext(DbContextOptions<HerstDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(Startup.ConnectionString);
     }
 }
 
