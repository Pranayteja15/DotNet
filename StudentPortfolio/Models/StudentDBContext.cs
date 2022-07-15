using Microsoft.EntityFrameworkCore;

namespace StudentPortfolio.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext>options):base(options)        
        {
                
        }

        DbSet<Student> Students { get; set; }
    }
}
