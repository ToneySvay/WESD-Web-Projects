using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EarlyLearningHub.Models;

namespace EarlyLearningHub.Pages.TableMaintenance.ELHub
{
    public class DeleteModel : PageModel
    {
        private readonly EarlyLearningHub.Models.EarlyLearningHubContext _context;

        public DeleteModel(EarlyLearningHub.Models.EarlyLearningHubContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hub Hub { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hub = await _context.Hub.FirstOrDefaultAsync(m => m.ElhId == id);

            if (Hub == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hub = await _context.Hub.FindAsync(id);

            if (Hub != null)
            {
                _context.Hub.Remove(Hub);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
