﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.ProviderType
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
            return Page();
        }

        [BindProperty]
        public Models.ProviderType ProviderType { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProviderType.Add(ProviderType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}