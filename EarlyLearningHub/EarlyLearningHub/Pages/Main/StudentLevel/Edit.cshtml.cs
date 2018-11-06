using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.StudentLevel
{
    public class EditModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public EditModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["SlCoId"] = new SelectList(_context.County, "CoId", "CoName");
           ViewData["SlErId"] = new SelectList(_context.ExitReason, "ErId", "ErType");
           ViewData["SlFirstLanguageLangId"] = new SelectList(_context.Language, "LangId", "LangName");
           ViewData["SlFosterCareOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlFreeReducedLunchProgramOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlHomelessStatusOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlIfspOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlIncId"] = new SelectList(_context.Income, "IncId", "IncRange");
           ViewData["SlMigrantStatusOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlOntId"] = new SelectList(_context.OtherNameType, "OntId", "OntName");
           ViewData["SlPrvdId"] = new SelectList(_context.Provider, "PrvdId", "PrvdName");
           ViewData["SlReId"] = new SelectList(_context.RaceEthnicity, "ReId", "ReName");
           ViewData["SlRecieveServicesOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlSecondLanguageLangId"] = new SelectList(_context.Language, "LangId", "LangName");
           ViewData["SlSnapOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlSsiOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlTanfOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
           ViewData["SlThirdLanguageLangId"] = new SelectList(_context.Language, "LangId", "LangName");
           ViewData["SlWicOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentLevelExists(StudentLevel.SlId))
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

        private bool StudentLevelExists(int id)
        {
            return _context.StudentLevel.Any(e => e.SlId == id);
        }
    }
}
