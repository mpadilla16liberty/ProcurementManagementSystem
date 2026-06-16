
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 * Purpose:
 * This controller manages the primary workflow of the Procurement Tracking Tool. It provides functionality for creating purchase requests, viewing submitted requests, 
 * approving or rejecting requests, and managing vendor information.
 *
 * Functionality:
 * - Displays the application home page.
 * - Creates new purchase requests.
 * - Stores purchase requests in memory during application execution.
 * - Allows users to approve or reject purchase requests.
 * - Maintains a vendor list including vendor name, point of contact (POC),
 *   and POC email address.
 * - Transfers submitted purchase request data to the approval page for review.
 *
 * Notes:
 * This controller was developed using ASP.NET Core MVC architecture and follows the Model-View-Controller design pattern. MVC concepts, form processing, and
 * web application development techniques were referenced from Carey (2020) and the Microsoft ASP.NET Core MVC documentation.
 *
 * References:
 * Carey, P. M. (2020). New perspectives on HTML5 and CSS3: Comprehensive (8th ed.). Cengage Learning.
 *
 * Microsoft. (n.d.). ASP.NET Core MVC overview. https://learn.microsoft.com/en-us/aspnet/core/mvc/
 */

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProcurementManagementSystem.Models;

namespace ProcurementManagementSystem.Controllers;



public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
