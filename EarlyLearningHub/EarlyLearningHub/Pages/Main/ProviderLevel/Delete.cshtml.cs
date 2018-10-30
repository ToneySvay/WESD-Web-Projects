using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.ProviderLevel
{
    public class DeleteModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public DeleteModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.ProviderLevel ProviderLevel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProviderLevel = await _context.ProviderLevel
                .Include(p => p.PlElh)
                .Include(p => p.PlLicencedOfficeChildCareOpt)
                .Include(p => p.PlPe)
                .Include(p => p.PlPrvd)
                .Include(p => p.PlPt)
                .Include(p => p.PlQr)
                .Include(p => p.PlSparkRatingBeginingOfYearSr)
                .Include(p => p.PlSparkRatingEndOfYearSr).FirstOrDefaultAsync(m => m.PlId == id);

            if (ProviderLevel == null)
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

            ProviderLevel = await _context.ProviderLevel.FindAsync(id);

            if (ProviderLevel != null)
            {
                _context.ProviderLevel.Remove(ProviderLevel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
