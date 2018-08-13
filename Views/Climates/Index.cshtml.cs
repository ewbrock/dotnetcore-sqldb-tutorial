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
    public class IndexModel : PageModel
    {
        private readonly WineTableMaint.Models.WineTableMaint _context;

        public IndexModel(WineTableMaint.Models.WineTableMaint context)
        {
            _context = context;
        }

        public IList<Climate> Climate { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var climates = from m in _context.Climate
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                climates = climates.Where(s => s.Name.Contains(searchString));
            }

            Climate = await climates.ToListAsync();
            
        }
    }
}
