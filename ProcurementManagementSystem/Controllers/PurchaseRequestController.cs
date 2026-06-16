
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
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

using Microsoft.AspNetCore.Mvc;
using ProcurementTrackingTool.Models;

namespace ProcurementTrackingTool.Controllers;

public class PurchaseRequestController : Controller
{
    private static List<PurchaseRequest> requests = new List<PurchaseRequest>();
    private static int nextId = 1;

private static List<Vendor> vendors = new List<Vendor>
{
    new Vendor { Id = 1, VendorName = "Dell Technologies", PocName = "John Smith", PocEmail = "john.smith@dell.com" },
    new Vendor { Id = 2, VendorName = "CDW-G", PocName = "Sarah Johnson", PocEmail = "sarah.johnson@cdwg.com" },
    new Vendor { Id = 3, VendorName = "SHI International", PocName = "Michael Brown", PocEmail = "michael.brown@shi.com" }
};

private static int nextVendorId = 4;
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(PurchaseRequest request)
    {
        request.Id = nextId++;
        request.Status = "Pending";

        requests.Add(request);

        return RedirectToAction("Approve");
    }

    public IActionResult Approve()
    {
        return View(requests);
    }

    public IActionResult ApproveRequest(int id)
    {
        var request = requests.FirstOrDefault(r => r.Id == id);

        if (request != null)
        {
            request.Status = "Approved";
        }

        return RedirectToAction("Approve");
    }

    public IActionResult RejectRequest(int id)
    {
        var request = requests.FirstOrDefault(r => r.Id == id);

        if (request != null)
        {
            request.Status = "Rejected";
        }

        return RedirectToAction("Approve");
    }

    public IActionResult Vendors()
{
    return View(vendors);
}

[HttpPost]
public IActionResult AddVendor(Vendor vendor)
{
    vendor.Id = nextVendorId++;

    vendors.Add(vendor);

    return RedirectToAction("Vendors");
}
}