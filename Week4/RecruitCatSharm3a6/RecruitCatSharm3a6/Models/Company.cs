using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Company
    {
        [Range(0, 1000000)]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Location { get; set; }
        [Range(0, 10000)]
        public int Rank { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Optional Start Date")]
        public DateTime optionalstartdate { get; set; }
        [DisplayName("Mini Salary")]
        [Range(0, 100000000)]
        public decimal MiniSalary { get; set; }
        [DisplayName("Max Salary")]
        [Range(0, 100000000)]
        public decimal MaxSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Hike Cycle")]
        public DateTime HikeCycle { get; set; }
        [DisplayName("Recruiting Position Name")]
        [Required]
        [StringLength(30)]
        public string RecruitingPositionName { get; set; }
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry")]
        public int IndustryId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle Jobtitle { get; set; }
        [DisplayName("Job Title")]
        public int JobtitleId { get; set; }
    }
}
