﻿using System;
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

        //public IList<Models.County> County { get;set; }
        public PaginatedList<Models.County> County { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            ////Add Sorting
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            /////

            ////Add Paging
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ////



            /////Add Search
            CurrentFilter = searchString;
            ////

            IQueryable<Models.County> countyIQ = from s in _context.County
                select s;

            ////Add Search
            if (!String.IsNullOrEmpty(searchString))
            {
                countyIQ = countyIQ.Where(s => s.CoName.Contains(searchString));
                                                 //|| s.FirstMidName.Contains(searchString));
            }

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

            //County = await countyIQ.AsNoTracking().ToListAsync();//await _context.County.ToListAsync();

            //Added Paging
            int pageSize = 10;
            County = await PaginatedList<Models.County>.CreateAsync(
                countyIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }


        //Add Sorting
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

    }
}
