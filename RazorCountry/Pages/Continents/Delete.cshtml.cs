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
    public class DeleteModel : PageModel
    {
        private readonly CountryContext _context;

        public DeleteModel(CountryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Continent Continent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Continents == null)
            {
                return NotFound();
            }

            var continent = await _context.Continents.FirstOrDefaultAsync(m => m.ID == id);

            if (continent == null)
            {
                return NotFound();
            }
            else 
            {
                Continent = continent;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            // Check to be sure, that the id is not null.
            if (id == null || _context.Continents == null)
            {
                return NotFound();
            }

            // Find continent.
            Continent continent = await _context.Continents.FindAsync(id);

            // Delete continent.
            if (continent != null)
            {
                Continent = continent;
                _context.Continents.Remove(Continent);
                // Save changes into database.
                await _context.SaveChangesAsync();
            }

            // Redirect user to the continents list page to see the changes.
            return RedirectToPage("./Index");
        }
    }
}
