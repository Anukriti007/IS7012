using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSharm3a6.Data;
using RecruitCatSharm3a6.Models;

namespace RecruitCatSharm3a6.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context _context;

        public DetailsModel(RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
