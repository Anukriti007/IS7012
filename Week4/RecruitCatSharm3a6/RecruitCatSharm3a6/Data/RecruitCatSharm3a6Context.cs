using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSharm3a6.Models;

namespace RecruitCatSharm3a6.Data
{
    public class RecruitCatSharm3a6Context : DbContext
    {
        public RecruitCatSharm3a6Context (DbContextOptions<RecruitCatSharm3a6Context> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSharm3a6.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatSharm3a6.Models.Company> Company { get; set; }

        public DbSet<RecruitCatSharm3a6.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatSharm3a6.Models.JobTitle> JobTitle { get; set; }
    }
}
