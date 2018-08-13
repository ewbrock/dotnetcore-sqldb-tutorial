using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WineTableMaint.Models;

namespace WineTableMaint.Pages.Climates
{
    public class CreateModel : PageModel
    {
        private readonly WineTableMaint.Models.WineTableMaint _context;

        public CreateModel(WineTableMaint.Models.WineTableMaint context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Climate Climate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Climate.Add(Climate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
