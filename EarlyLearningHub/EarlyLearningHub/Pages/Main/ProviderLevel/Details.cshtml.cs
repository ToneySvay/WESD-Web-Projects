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
    public class DetailsModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public DetailsModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

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
                .Include(p => p.PlPt)
                .Include(p => p.PlPtNavigation)
                .Include(p => p.PlQr)
                .Include(p => p.PlSparkRatingBeginingOfYearSr)
                .Include(p => p.PlSparkRatingEndOfYearSr).FirstOrDefaultAsync(m => m.PlId == id);

            if (ProviderLevel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
