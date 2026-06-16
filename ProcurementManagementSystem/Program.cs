
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
 * Purpose:
 * This file serves as the application startup and configuration file for the Procurement Tracking Tool. It configures application services, establishes the request 
 * processing pipeline, and defines routing rules used throughout the ASP.NET Core MVC web application.
 *
 * Functionality:
 * - Initializes the ASP.NET Core web application.
 * - Registers MVC controller and view services.
 * - Configures application middleware.
 * - Enables HTTPS redirection and static file support.
 * - Establishes application routing.
 * - Defines the default application landing page.
 * - Launches the Procurement Tracking Tool.
 *
 * Notes:
 * This file was developed using ASP.NET Core MVC architecture and follows Microsoft's recommended startup configuration practices. Routing was
 * configured to direct users to the PurchaseRequest controller and Index view when the application first loads. This design supports a centralized
 * procurement workflow beginning at the application's welcome page.
 *
 * References:
 * Carey, P. M. (2020). New perspectives on HTML5 and CSS3: Comprehensive (8th ed.). Cengage Learning.
 *
 * GitHub. (n.d.). Quickstart for GitHub Codespaces. https://docs.github.com/en/codespaces/getting-started/quickstart
 *
 * Microsoft. (n.d.). ASP.NET Core MVC overview. https://learn.microsoft.com/en-us/aspnet/core/mvc/
 */


var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PurchaseRequest}/{action=Index}/{id?}");

app.Run();