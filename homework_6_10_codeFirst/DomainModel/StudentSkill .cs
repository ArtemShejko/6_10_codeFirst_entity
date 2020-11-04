using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst.DomainModel
{
    public class StudentSkill
    {
        [Key]
        public int skillId { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 2)]
        public string skillName { get; set; }
        public List<Student> students { get; set; }
     //   public Student Student { get; set; }

    }
}
