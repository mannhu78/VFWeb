using Microsoft.EntityFrameworkCore;


namespace webVF.DataBase
{
    public class VinFastDbContext : DbContext
    {
        public VinFastDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
    }

