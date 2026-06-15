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