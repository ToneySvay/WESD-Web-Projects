using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.RaceEthnicity
{
    public class IndexModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public IndexModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public IList<Models.RaceEthnicity> RaceEthnicity { get;set; }

        public async Task OnGetAsync()
        {
            RaceEthnicity = await _context.RaceEthnicity.ToListAsync();
        }
    }
}
