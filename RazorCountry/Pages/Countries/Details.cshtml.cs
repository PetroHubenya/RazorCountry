using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;

namespace RazorCountry.Pages.Countries
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCountry.Data.CountryContext _context;

        public DetailsModel(RazorCountry.Data.CountryContext context)
        {
            _context = context;
        }

      public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Countries == null)
            {
                return NotFound();
            }

            var country = await _context.Countries.FirstOrDefaultAsync(m => m.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            else 
            {
                Country = country;
            }
            return Page();
        }
    }
}
