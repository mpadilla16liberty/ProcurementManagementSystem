
/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
 * Purpose:
 * This model represents a vendor within the Procurement Tracking Tool. Vendors are organizations that provide hardware, software, or related services required 
 * to fulfill procurement requests. The model stores the vendor name and primary point of contact information.
 *
 * Functionality:
 * - Stores vendor information used during the procurement process.
 * - Records the vendor name.
 * - Maintains a primary point of contact (POC).
 * - Stores the POC email address for communication purposes.
 * - Supports vendor management and future procurement activities.
 *
 * Notes:
 *
 * References:
 * Carey, P. M. (2020). New perspectives on HTML5 and CSS3: Comprehensive (8th ed.). Cengage Learning.
 *
 * Microsoft. (n.d.). ASP.NET Core MVC overview. https://learn.microsoft.com/en-us/aspnet/core/mvc/
 */

namespace ProcurementTrackingTool.Models;

public class Vendor
{
    public int Id { get; set; }

    public string VendorName { get; set; } = "";

    public string PocName { get; set; } = "";

    public string PocEmail { get; set; } = "";
}