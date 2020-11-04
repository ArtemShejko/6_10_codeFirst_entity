using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst.DomainModel
{
    public class StudentContext : DbContext
    {
            public StudentContext() : base("name=Student")
            {
                Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());
            }
            public DbSet<Student> Students { get; set; }
            public DbSet<StudentWork> StudentWork { get; set; }
            public DbSet<StudentSkill> StudentSkill { get; set; }
            public DbSet<StudentSkillStudents> StudentSkillStudents { get; set; }



    }
}
