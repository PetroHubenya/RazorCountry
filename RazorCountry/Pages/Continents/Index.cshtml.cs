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
    public class IndexModel : PageModel
    {
        private readonly CountryContext _context;

        public IndexModel(CountryContext context)
        {
            _context = context;
        }

        public List<Continent> Continents { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Continents != null)
            {
                Continents = await _context.Continents.ToListAsync();
            }
        }
    }
}
