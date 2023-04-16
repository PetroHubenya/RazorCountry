using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;

namespace RazorCountry.Pages.Continents
{
    public class DetailsModel : PageModel
    {
        private readonly CountryContext _context;

        public DetailsModel(CountryContext context)
        {
            _context = context;
        }

        public Continent Continent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Continent = await _context.Continents
                .Include(c => c.Countries)
                .AsNoTracking()
				.FirstOrDefaultAsync(m => m.ID == id);
            
            return Page();
        }
    }
}
