using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Candidate
    {
        [Range(0, 100000)]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Of Joining")]
        public DateTime DateOfJoining { get; set; }
        [DisplayName("Target Salary")]
        [Range(0, 100000000)]
        public decimal TargetSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Optional Date & Time")]
        public DateTime OptionalStartDate { get; set; }
        [DisplayName("First Name")]
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [DisplayName("Gender")]
        [Required]
        [StringLength(1)]
        public string Gender { get; set; }
        [DisplayName("Bonus Given")]
        [Range(0, 1000000)]
        public decimal? BonusGiven { get; set; }
        [DisplayName("Ready To Relocate")]
        public bool ReadyToRelocate { get; set; }
        [DisplayName("Company")]
        public Company Company { get; set; }
        [DisplayName("Company")]
        public int? CompanyId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry")]
        public int IndustryId { get; set; }
    }
}
