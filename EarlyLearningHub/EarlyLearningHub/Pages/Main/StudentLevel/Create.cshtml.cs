using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.Main.StudentLevel
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
        ViewData["SlCoId"] = new SelectList(_context.County, "CoId", "CoName");
        ViewData["SlErId"] = new SelectList(_context.ExitReason, "ErId", "ErType");
        ViewData["SlFirstLanguageLangId"] = new SelectList(_context.Language, "LangId", "LangName");
        ViewData["SlFosterCareOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
        ViewData["SlFreeReducedLunchProgramOptId"] = new SelectList(_context.Option, "OptId", "OptValue");
        ViewData["SlGeId"] = new SelectList(_context.Gender, "GeId", "GeName");
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

        [BindProperty]
        public Models.StudentLevel StudentLevel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StudentLevel.Add(StudentLevel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}