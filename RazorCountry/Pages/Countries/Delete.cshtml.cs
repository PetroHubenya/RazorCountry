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
    public class DeleteModel : PageModel
    {
        private readonly CountryContext _context;

        public DeleteModel(CountryContext context)
        {
            _context = context;
        }

        public CountryStat Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Countries == null)
            {
                return NotFound();
            }

            var country = from c in _context.Countries
                          where c.ID == id
                          select new CountryStat
                          {
                              ID = c.ID,
                              ContinentID = c.ContinentID,
                              Name = c.Name,
                              Population = c.Population,
                              Area = c.Area,
                              UnitedNationsDate = c.UnitedNationsDate,
                              Density = c.Population / c.Area
                          };

            Country = await country.SingleOrDefaultAsync();

            if (Country == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            // Check to be sure, that the id is not null.
            if (id == null)
            {
                return NotFound();
            }

            // Find continent.
            Country Country = await _context.Countries.FindAsync(id);

            // Delete continent.
            if (Country != null)
            {
                _context.Countries.Remove(Country);
            }

            // Save changes into database.
            await _context.SaveChangesAsync();

            // Redirect user to the continents list page to see the changes.
            return RedirectToPage("./Index");
        }
    }
}
