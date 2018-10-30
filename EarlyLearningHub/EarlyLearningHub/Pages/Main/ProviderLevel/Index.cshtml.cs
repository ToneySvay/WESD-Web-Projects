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
    public class IndexModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public IndexModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public IList<Models.ProviderLevel> ProviderLevel { get;set; }

        public async Task OnGetAsync()
        {
            ProviderLevel = await _context.ProviderLevel
                .Include(p => p.PlElh)
                .Include(p => p.PlLicencedOfficeChildCareOpt)
                .Include(p => p.PlPe)
                .Include(p => p.PlPt)
                .Include(p => p.PlPtNavigation)
                .Include(p => p.PlQr)
                .Include(p => p.PlSparkRatingBeginingOfYearSr)
                .Include(p => p.PlSparkRatingEndOfYearSr).ToListAsync();
        }
    }
}
