using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class JobTitle
    {
        [Range(0, 100000)]
        public int Id { get; set; }
        [DisplayName("Working Hours")]
        [Range(0, 10000)]
        public int WorkingHours { get; set; }
        [DisplayName("Mini Salary")]
        [Range(0, 100000000)]
        public decimal MiniSalary { get; set; }
        [DisplayName("Max Salary")]
        [Range(0, 100000000)]
        public decimal MaxSalary { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
