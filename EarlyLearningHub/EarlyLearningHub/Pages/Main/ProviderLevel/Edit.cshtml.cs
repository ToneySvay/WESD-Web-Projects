using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.ProviderLevel
{
    public class EditModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public EditModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
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
           ViewData["PlElhId"] = new SelectList(_context.Hub, "ElhId", "ElhName");
           ViewData["PlLicencedOfficeChildCareOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["PlPeId"] = new SelectList(_context.Person, "PeId", "PeEmail");
           ViewData["PlPrvdId"] = new SelectList(_context.Provider, "PrvdId", "PrvdName");
           ViewData["PlPtId"] = new SelectList(_context.ProviderType, "PtId", "PtName");
           ViewData["PlQrId"] = new SelectList(_context.QuarterlyRange, "QrId", "QuarterDateRange");
           ViewData["PlSparkRatingBeginingOfYearSrId"] = new SelectList(_context.SparkRating, "SrId", "SrName");
           ViewData["PlSparkRatingEndOfYearSrId"] = new SelectList(_context.SparkRating, "SrId", "SrName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProviderLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderLevelExists(ProviderLevel.PlId))
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

        private bool ProviderLevelExists(int id)
        {
            return _context.ProviderLevel.Any(e => e.PlId == id);
        }
    }
}
