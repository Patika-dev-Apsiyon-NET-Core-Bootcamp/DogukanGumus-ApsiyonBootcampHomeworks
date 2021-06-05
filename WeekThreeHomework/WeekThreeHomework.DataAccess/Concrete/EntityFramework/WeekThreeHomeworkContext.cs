using Microsoft.EntityFrameworkCore;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.DataAccess.Concrete.EntityFramework
{
    public class WeekThreeHomeworkContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=WeekThreeHomeworkDb;User Id=sa;Password=Password.1;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}