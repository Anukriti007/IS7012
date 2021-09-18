using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Company
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rank { get; set; }
        public DateTime optionalstartdate { get; set; }
        public decimal MiniSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime HikeCycle { get; set; }
        public string RecruitingPositionName { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int? CandidatesId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle Jobtitle { get; set; }
        public int JobtitleId { get; set; }
    }
}
