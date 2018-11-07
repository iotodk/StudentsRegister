using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentsRegister.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("Students")
        {
            Database.SetInitializer<StudentsContext>(new DBInitializer());
        }
        public DbSet<Student> Students { get; set;  }
    }

    public class DBInitializer : DropCreateDatabaseIfModelChanges<StudentsContext>
    {
        protected override void Seed(StudentsContext context)
        {
            var students = new List<Student>
            {
                new Student { Name = "Ion Toporan", CPR = "098765-4321", BirthDate = new DateTime(1960, 5, 31), Gender = Student.GenderType.Male},
                new Student { Name = "John Doe", CPR = "088765-4321", BirthDate = new DateTime(1989, 5, 31), Gender = Student.GenderType.Male},
                new Student { Name = "Donald Duck", CPR = "098765-4321", BirthDate = new DateTime(1921, 5, 31), Gender = Student.GenderType.Male},
                new Student { Name = "Jane Doe", CPR = "098765-4321", BirthDate = new DateTime(2000, 5, 31), Gender = Student.GenderType.Female},
                new Student { Name = "Anne Doe", CPR = "098765-4321", BirthDate = new DateTime(2000, 5, 31), Gender = Student.GenderType.Female},
                new Student { Name = "Sarah Doe", CPR = "098765-4321", BirthDate = new DateTime(2000, 5, 31), Gender = Student.GenderType.Female}
            };
            students.ForEach(s => context.Students.Add(s));
        }
    }

}