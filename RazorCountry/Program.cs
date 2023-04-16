using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CountryContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("CountryContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// In production environments the UseExceptionHandler() will catch and log errors and route users to a general error page.
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

// UseHttpsRedirection() redirects HTTP requests to the more secure HTTPS protocol.
app.UseHttpsRedirection();

/* UseStaticFiles() allows static files, like CSS and images, to be served.
 * Static files are stored in the wwwroot directory */
app.UseStaticFiles();

// UseRouting() allows route matching.
app.UseRouting();

// pp.UseAuthorization() method adds an authorization middleware component to the application
app.UseAuthorization();

// The UseWelcomePage middleware component displays a default welcome page. It can be added to the pipeline if needed.
// app.UseWelcomePage();

/* UseEndpoints() adds endpoint execution to the middleware pipeline.
 * It runs the code associated with the selected endpoint. 
 * It's functionality is built into the app.MapRazorPages() method now.*/
app.MapRazorPages();

/* View the IApplicationBuilder documentation 
 * to see a complete list of the built-in middleware components
 * available via the IApplicationBuilder interface.
 * https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.iapplicationbuilder?view=aspnetcore-7.0 */

app.Run();