using Microsoft.EntityFrameworkCore;

namespace fortifyTask.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                
        }

        public DbSet<TaskModel> TaskModels { get; set; }
    }
}
