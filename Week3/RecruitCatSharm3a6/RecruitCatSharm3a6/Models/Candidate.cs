using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Candidate
    {
        public int Id { get; set; } 

        public DateTime DateOfJoining { get; set; } 

        public decimal TargetSalary { get; set; } 

        public DateTime OptionalStartDate { get; set; } 

        public string FirstName { get; set; } 

        public string LastName { get; set; } 

        public string Gender { get; set; }

        public decimal? BonusGiven { get; set; }

        public bool ReadyToRelocate { get; set; }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        public JobTitle JobTitle { get; set; }

        public int JobTitleId { get; set; }

        public Industry Industry { get; set; }

        public int IndustryId { get; set; }
    }
}
