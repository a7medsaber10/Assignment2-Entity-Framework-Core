using Assignment2_Entity_Framework_Core.Configurations;
using Assignment2_Entity_Framework_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Entity_Framework_Core.Contexts
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = DESKTOP-4J5GA96 ; Initial Catalog = ITI_EF ; Integrated Security = True");
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI_EFCore ; Trusted_Connection = True; Encrypt = False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());

            modelBuilder.ApplyConfiguration(new CourseConfigurations());

            modelBuilder.ApplyConfiguration(new DepartmentsConfiguration());

            modelBuilder.ApplyConfiguration(new InstructorConfigurations());

            modelBuilder.ApplyConfiguration(new TopicConfigurations());
        }
    }
}
