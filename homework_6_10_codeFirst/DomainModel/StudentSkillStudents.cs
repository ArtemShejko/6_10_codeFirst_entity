using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst.DomainModel
{
    public class StudentSkillStudents
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Key, Column(Order = 2)]
        public int skillId { get; set; }

        public Student Student { get; set; }
        public StudentSkill StudentSkill { get; set; }
    }
}
