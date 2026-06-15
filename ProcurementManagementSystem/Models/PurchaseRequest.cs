

namespace ProcurementTrackingTool.Models;

public class PurchaseRequest
{
    public int Id { get; set; }

    public string VendorName { get; set; } = "";

    public string ItemName { get; set; } = "";

    public decimal Cost { get; set; }

    public string EndUserName { get; set; } = "";

    public string EndUserEmail { get; set; } = "";

    public string Status { get; set; } = "Pending";
}