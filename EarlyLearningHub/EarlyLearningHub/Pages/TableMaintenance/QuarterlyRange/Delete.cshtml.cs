using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.QuarterlyRange
{
    public class DeleteModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public DeleteModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.QuarterlyRange QuarterlyRange { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuarterlyRange = await _context.QuarterlyRange.FirstOrDefaultAsync(m => m.QrId == id);

            if (QuarterlyRange == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuarterlyRange = await _context.QuarterlyRange.FindAsync(id);

            if (QuarterlyRange != null)
            {
                _context.QuarterlyRange.Remove(QuarterlyRange);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
