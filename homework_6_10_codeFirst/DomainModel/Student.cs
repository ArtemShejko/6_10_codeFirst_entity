using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst.DomainModel
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        [StringLength(30, MinimumLength = 2)]
        public string GroupName { get; set; }
        public float AvMark { get; set; }
        public Decimal? Bonus { get; set; }
        public List <StudentSkill> studentSkills { get; set; }
        public StudentWork StudentWork { get; set; }
    }
}
