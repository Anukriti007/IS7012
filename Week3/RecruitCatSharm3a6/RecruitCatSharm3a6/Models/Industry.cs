using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string IndustryLocation { get; set; }
        public string IndustryType { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int CandidatesId { get; set; }
        public List<Company> Companies { get; set; }
        public int CompaniesId { get; set; }
    }
}
