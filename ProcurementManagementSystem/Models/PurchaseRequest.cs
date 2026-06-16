
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
 * Purpose:
 * This model represents a purchase request submitted by a user within the
 * Procurement Tracking Tool. It stores procurement information needed to initiate the purchasing process and serves as the primary record used
 * throughout the request approval workflow.
 *
 * Functionality:
 * - Stores vendor information for the requested purchase.
 * - Records the item being requested.
 * - Tracks the estimated purchase cost.
 * - Stores end-user contact information.
 * - Maintains the current request status.
 * - Supports request creation, review, approval, and rejection activities.
 *
 * Notes:
 * This model is used by the PurchaseRequestController and associated Razor views to collect, display, and manage procurement request information.
 * The model supports the business objective of tracking procurement actions from initial request submission through approval.
 *
 * References:
 * Carey, P. M. (2020). New perspectives on HTML5 and CSS3: Comprehensive (8th ed.). Cengage Learning.
 *
 * Microsoft. (n.d.). Razor syntax reference for ASP.NET Core.https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor
 */

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