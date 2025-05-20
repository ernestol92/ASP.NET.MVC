using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ProjectEntity> Projects { get; set; } = null!;
        public DbSet<MemberEntity> Members { get; set; } = null!;
        public DbSet<StatusEntity> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StatusEntity>().HasData(
                new StatusEntity { Id = 1, Status = "Not Started" },
                new StatusEntity { Id = 2, Status = "In Progress" },
                new StatusEntity { Id = 3, Status = "Completed" }
            );
        }

    }

}
