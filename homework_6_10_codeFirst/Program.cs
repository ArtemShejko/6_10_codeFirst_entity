using homework_6_10_codeFirst.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            Student student = new Student
            {
                FirstName = "Vasja",
                LastName = "Ivanov",
                Birthday = new DateTime(2000, 8, 31),
                AvMark = 4.85f,
                Bonus = 2300M
            };
            Student addStudent = context.Students.Add(student);
            StudentSkill skillCsharp = new StudentSkill { skillName = "C#" };
            StudentSkill skillCplus = new StudentSkill { skillName = "C++" };
            StudentSkill skillSql = new StudentSkill { skillName = "Sql" };
            StudentSkill skillAdo = new StudentSkill { skillName = "AdoNet" };
            StudentSkill skillCJava = new StudentSkill { skillName = "Java" };
            StudentSkillStudents studentSkillStudents = new StudentSkillStudents { skillId = 1, StudentId = 1 };
            context.StudentSkill.AddRange(new StudentSkill[] { skillCsharp , skillCplus , skillSql, skillAdo, skillCJava });
            StudentWork studentWork = new StudentWork { Specialization = "Math Analytic", Student = student, StartWorkDate = DateTime.Now };
            context.StudentWork.Add(studentWork);
            context.StudentSkillStudents.Add(studentSkillStudents);
            context.SaveChanges();
        }
    }
}
