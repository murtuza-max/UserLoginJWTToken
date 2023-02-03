using Microsoft.EntityFrameworkCore;
using UserLoginJWTToken.Model;

namespace DeleteUser.Model
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options)
           : base(options)
        { }

        public DbSet<GetInformation> userdetail { get; set; }
        public DbSet<RegisterUserRequest> crudapplication { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
