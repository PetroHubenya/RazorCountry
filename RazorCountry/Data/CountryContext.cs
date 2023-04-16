using Microsoft.EntityFrameworkCore;
using RazorCountry.Models;

namespace RazorCountry.Data
{
	public class CountryContext : DbContext
	{
		public CountryContext(DbContextOptions<CountryContext> options) : base(options)
		{
			/* This method fullfill the database, whehn it is being created.
			 * Delete the database file if it must be initialized ones again. */
			DbInitializerFull.Initialize(context: this);
		}

		public DbSet<Country> Countries { get; set; }
		public DbSet<Continent> Continents { get; set; }


	}
}
