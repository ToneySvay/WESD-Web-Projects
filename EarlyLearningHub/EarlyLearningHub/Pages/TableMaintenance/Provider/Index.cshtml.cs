using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.Provider
{
    public class IndexModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public IndexModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public IList<Models.Provider> Provider { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            TypeSort = sortOrder == "Type" ? "type_desc" : "Type";

            IQueryable<Models.Provider> providerIQ = from s in _context.Provider.Include(p => p.PrvdPt)
                                                     select s;


            switch (sortOrder)
            {
                case "name_desc":
                    providerIQ = providerIQ.OrderByDescending(s => s.PrvdName);
                    break;
                case "Type":
                    providerIQ = providerIQ.OrderBy(s => s.PrvdPt);
                    break;
                case "type_desc":
                    providerIQ = providerIQ.OrderByDescending(s => s.PrvdPt);
                    break;
                default:
                    providerIQ = providerIQ.OrderBy(s => s.PrvdName);
                    break;
            }






            //Provider = await _context.Provider.Include(p => p.PrvdPt).ToListAsync();
            //Provider = await providerIQ.AsNoTracking().ToListAsync();
            Provider = await providerIQ.AsNoTracking().ToListAsync();

            //Provider = await PaginatedList<Models.Provider>.CreateAsync(providerIQ.AsNoTracking(), pageIndex ?? 1, pageSize);


        }

        public string NameSort { get; set; }
        public string TypeSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
    }


}
