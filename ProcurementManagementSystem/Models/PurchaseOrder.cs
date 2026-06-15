

namespace ProcurementManagementSystem.Models;

public class PurchaseOrder
{
    public int PurchaseOrderId { get; set; }

    public int RequestID { get; set; }

    public int VendorID { get; set; }

    public DateTime PODate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = "";
}