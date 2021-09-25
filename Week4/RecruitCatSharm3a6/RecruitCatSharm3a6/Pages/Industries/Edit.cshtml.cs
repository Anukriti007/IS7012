using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatSharm3a6.Data;
using RecruitCatSharm3a6.Models;

namespace RecruitCatSharm3a6.Pages.Industries
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context _context;

        public EditModel(RecruitCatSharm3a6.Data.RecruitCatSharm3a6Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.ID == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Industry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndustryExists(Industry.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IndustryExists(int id)
        {
            return _context.Industry.Any(e => e.ID == id);
        }
    }
}
