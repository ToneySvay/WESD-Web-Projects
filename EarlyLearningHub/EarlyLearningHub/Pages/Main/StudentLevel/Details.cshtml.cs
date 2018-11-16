using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.StudentLevel
{
    public class DetailsModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public DetailsModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public Models.StudentLevel StudentLevel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentLevel = await _context.StudentLevel
                .Include(s => s.SlCo)
                .Include(s => s.SlEr)
                .Include(s => s.SlFirstLanguageLang)
                .Include(s => s.SlFosterCareOpt)
                .Include(s => s.SlFreeReducedLunchProgramOpt)
                .Include(s => s.SlGe)
                .Include(s => s.SlHomelessStatusOpt)
                .Include(s => s.SlIfspOpt)
                .Include(s => s.SlInc)
                .Include(s => s.SlMigrantStatusOpt)
                .Include(s => s.SlOnt)
                .Include(s => s.SlPrvd)
                .Include(s => s.SlRe)
                .Include(s => s.SlRecieveServicesOpt)
                .Include(s => s.SlSecondLanguageLang)
                .Include(s => s.SlSnapOpt)
                .Include(s => s.SlSsiOpt)
                .Include(s => s.SlTanfOpt)
                .Include(s => s.SlThirdLanguageLang)
                .Include(s => s.SlWicOpt).FirstOrDefaultAsync(m => m.SlId == id);

            if (StudentLevel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
