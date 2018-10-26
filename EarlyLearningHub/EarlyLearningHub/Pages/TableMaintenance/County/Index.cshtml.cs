using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.County
{
    public class IndexModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public IndexModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public IList<Models.County> County { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            ////Add Sorting
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            IQueryable<Models.County> countyIQ = from s in _context.County
                select s;

            switch (sortOrder)
            {
                case "name_desc":
                    countyIQ = countyIQ.OrderByDescending(s => s.CoName);
                    break;
                default:
                    countyIQ = countyIQ.OrderBy(s => s.CoName);
                    break;
            }
            ////////////////

            County = await countyIQ.AsNoTracking().ToListAsync();//await _context.County.ToListAsync();
        }


        //Add Sorting
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

    }
}
