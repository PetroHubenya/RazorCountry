using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;

namespace RazorCountry.Pages.Continents
{
    public class EditModel : PageModel
    {
        private readonly CountryContext _context;

        public EditModel(CountryContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Continent Continent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                Continent = new Continent();
            }
            else
            {
                Continent = await _context.Continents.FindAsync(id);
            }  
            
            if (Continent == null)
            {
                return NotFound();
            }

            return Page();
        }        
        public async Task<IActionResult> OnPostAsync(string id)
        {
            // if (!ModelState.IsValid)
            {
                // return Page();
            }

            if (id == null)
            {
                _context.Continents.AddAsync(Continent);
            }
            else
            {
                _context.Attach(Continent).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
