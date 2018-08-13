using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Pages.Climates
{
    public class DetailsModel : PageModel
    {
        private readonly DotNetCoreSqlDb.Models.WineContext _context;

        public DetailsModel(DotNetCoreSqlDb.Models.WineContext context)
        {
            _context = context;
        }

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
    }
}
