using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab05b1.DAL
{
    public partial class ModelStudentDB : DbContext
    {
        public ModelStudentDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .Property(e => e.FacultyName)
                .IsFixedLength();

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Majors)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Major)
                .HasForeignKey(e => new { e.FacultyID, e.MajorID });

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Fullname)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Avatar)
                .IsFixedLength();
        }
    }
}
