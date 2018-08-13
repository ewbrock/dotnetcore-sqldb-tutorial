using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WineTableMaint.Models;

namespace WineTableMaint.Pages.Climates
{
    public class DeleteModel : PageModel
    {
        private readonly WineTableMaint.Models.WineTableMaintContext _context;

        public DeleteModel(WineTableMaint.Models.WineTableMaintContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Climate = await _context.Climate.FindAsync(id);

            if (Climate != null)
            {
                _context.Climate.Remove(Climate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
