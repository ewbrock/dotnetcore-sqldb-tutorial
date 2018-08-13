using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WineTableMaint.Models;

namespace WineTableMaint.Pages.Climates
{
    public class EditModel : PageModel
    {
        private readonly WineTableMaint.Models.WineContext _context;

        public EditModel(WineTableMaint.Models.WineContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Climate Climate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Climate = await _context.Climate.FirstOrDefaultAsync(m => m.ClimateID == id);

            if (Climate == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Climate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClimateExists(Climate.ClimateID))
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

        private bool ClimateExists(int id)
        {
            return _context.Climate.Any(e => e.ClimateID == id);
        }
    }
}
