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
using System.ComponentModel.DataAnnotations;

namespace RazorCountry.Pages.Countries
{
    public class IndexModel : PageModel
    {
        private readonly CountryContext _context;

        public IndexModel(CountryContext context)
        {
            _context = context;
        }
        
        public List<Country> Countries { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Name";
        
        [BindProperty(SupportsGet = true)]
        public string SelectedContinent { get; set; }
        public SelectList Continents { get; private set; }
        
        public async Task OnGetAsync()
        {
            var countries = from c in _context.Countries
                            select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                countries = countries.Where(c => c.Name.Contains(SearchString));
            }

            switch (SortField)
            {
                case "ID":
                    countries = countries.OrderBy(c => c.ID);
                    break;
                case "Name":
                    countries = countries.OrderBy(c => c.Name);
                    break;
                case "ContinentID":
                    countries = countries.OrderBy(c => c.ContinentID);
                    break;
            }

            if (!string.IsNullOrEmpty(SelectedContinent))
            {
                countries = countries.Where(c => c.ContinentID == SelectedContinent);
            }

            // LINQ is used to gather all continents while sorting then alphabetically:
            IQueryable<string> continentQuery = from c in _context.Continents
                                                orderby c.ID
                                                select c.ID;

            Continents = new SelectList(await continentQuery.ToListAsync());

            Countries = await countries.ToListAsync();
        }
    }
}
