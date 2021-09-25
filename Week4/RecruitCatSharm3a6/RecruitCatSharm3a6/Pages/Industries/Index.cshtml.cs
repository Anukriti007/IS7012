using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSharm3a6.Data;
using RecruitCatSharm3a6.Models;

namespace RecruitCatSharm3a6.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context _context;

        public IndexModel(RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
