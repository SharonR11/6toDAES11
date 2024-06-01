using Microsoft.EntityFrameworkCore;

namespace _6toDAES11.Models
{
    public class ConectDB: DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-26\\SQLEXPRESS; Initial Catalog=SharonDB; trustservercertificate=True;User Id=userSharon;Password=010203");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .HasOne(s => s.Grade)
        //        .WithMany(g => g.Students)
        //        .HasForeignKey(s => s.GradeID);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
