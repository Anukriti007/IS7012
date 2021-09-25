using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSharm3a6.Models
{
    public class Industry
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Range(0, 100000)]
        public int ID { get; set; }
        [DisplayName("Industry Location")]
        [Required]
        [StringLength(30)]
        public string IndustryLocation { get; set; }
        [DisplayName("Industry Type")]
        [Required]
        [StringLength(30)]
        public string IndustryType { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
