
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
 * Purpose:
 * This model represents a purchase order within the Procurement Tracking Tool. The purchase order serves as the final procurement document generated after
 * a purchase request has been reviewed and approved. 
 *
 * Functionality:
 * - Stores a unique purchase order identifier.
 * - Links the purchase order to an approved purchase request.
 * - Associates the purchase order with a vendor.
 * - Records the purchase order date.
 * - Stores the total purchase amount.
 * - Tracks the current status of the purchase order.
 *
 * References:
 * Carey, P. M. (2020). New perspectives on HTML5 and CSS3: Comprehensive (8th ed.). Cengage Learning.
 *
 * Deltek. (n.d.). FAR vs. DFARS: What is the difference and how to prepare. https://www.deltek.com/en/government-contracting/guide/federal-acquisition-regulation/vs-dfars
 */

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