using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6_10_codeFirst.DomainModel
{
    public class StudentWork
    {
       
        [Key]
        [ForeignKey ("Student")]
        public int studentId { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime StartWorkDate { get; set; }
        [Required]
        [StringLength(128, MinimumLength = 2)]
        public string Specialization { get; set; }
        public Student Student { get; set; }
    }
}
