using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.ProviderLevel
{
    public class CreateModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public CreateModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PlElhId"] = new SelectList(_context.Hub, "ElhId", "ElhName");
        ViewData["PlLicencedOfficeChildCareOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
        ViewData["PlPeId"] = new SelectList(_context.Person, "PeId", "PeEmail");
        ViewData["PlPtId"] = new SelectList(_context.Provider, "PrvdId", "PrvdName");
        ViewData["PlPtId"] = new SelectList(_context.ProviderType, "PtId", "PtName");
        ViewData["PlQrId"] = new SelectList(_context.QuarterlyRange, "QrId", "QrName");
        ViewData["PlSparkRatingBeginingOfYearSrId"] = new SelectList(_context.SparkRating, "SrId", "SrName");
        ViewData["PlSparkRatingEndOfYearSrId"] = new SelectList(_context.SparkRating, "SrId", "SrName");
            return Page();
        }

        [BindProperty]
        public Models.ProviderLevel ProviderLevel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProviderLevel.Add(ProviderLevel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}