
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
using ProcurementTrackingTool.Data;
using ProcurementTrackingTool.Models;

namespace ProcurementTrackingTool.Controllers;

public class PurchaseRequestController : Controller
{
    private readonly ProcurementDbContext _context;

    public PurchaseRequestController(ProcurementDbContext context)
    {
        _context = context;
    }

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
        request.Status = "Pending";

        _context.PurchaseRequests.Add(request);
        _context.SaveChanges();

        return RedirectToAction("Approve");
    }

    public IActionResult Approve()
    {
        var requests = _context.PurchaseRequests.ToList();

        return View(requests);
    }

    public IActionResult ApproveRequest(int id)
    {
        var request = _context.PurchaseRequests.FirstOrDefault(r => r.Id == id);

        if (request != null)
        {
            request.Status = "Approved";
            _context.SaveChanges();
        }

        return RedirectToAction("Approve");
    }

    public IActionResult RejectRequest(int id)
    {
        var request = _context.PurchaseRequests.FirstOrDefault(r => r.Id == id);

        if (request != null)
        {
            request.Status = "Rejected";
            _context.SaveChanges();
        }

        return RedirectToAction("Approve");
    }

    public IActionResult Vendors()
    {
        var vendors = _context.Vendors.ToList();

        return View(vendors);
    }

    [HttpPost]
    public IActionResult AddVendor(Vendor vendor)
    {
        _context.Vendors.Add(vendor);
        _context.SaveChanges();

        return RedirectToAction("Vendors");
    }
}