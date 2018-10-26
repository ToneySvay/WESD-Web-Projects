using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.ProviderType
{
    public class IndexModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public IndexModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        public PaginatedList<Models.ProviderType> ProviderType { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Models.ProviderType> providerTypeIQ = from s in _context.ProviderType
                select s;

            //Add Search
            if (!String.IsNullOrEmpty(searchString))
            {
                providerTypeIQ = providerTypeIQ.Where(s => s.PtName.Contains(searchString));
            }

            //Add Sorting
            switch (sortOrder)
            {
                case "name_desc":
                    providerTypeIQ = providerTypeIQ.OrderByDescending(s => s.PtName);
                    break;
                default:
                    providerTypeIQ = providerTypeIQ.OrderBy(s => s.PtName);
                    break;
            }

            //Add Paging
            int pageSize = 10;
            ProviderType = await PaginatedList<Models.ProviderType>.CreateAsync(
                providerTypeIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }


        //Add Sorting
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

    }
}