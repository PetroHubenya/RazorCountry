using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;

namespace RazorCountry.Pages
{
	public class IndexModel : PageModel
	{
		private readonly CountryContext _context;

		public IndexModel(CountryContext context)
		{
			_context = context;
		}

		public List<Continent> Continents { get; set; }
		public List<Country> Countries { get; set; }

		public async Task OnGetAsync()
		{
			Continents = await _context.Continents.ToListAsync();
			Countries = await _context.Countries.ToListAsync();
		}
	}
}