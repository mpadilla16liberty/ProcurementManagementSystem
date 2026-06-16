/*
 * Procurement Tracking Tool
 * CSIS 483 Capstone Project
 * Moses Padilla
 *
 * Purpose:
 * This model supports application error handling within the ASP.NET Core MVC framework. It stores a request identifier that can be displayed to users
 * when an application error occurs, allowing easier troubleshooting and debugging during development and testing.
 *
 * Functionality:
 * - Stores the current request ID.
 * - Determines whether the request ID should be displayed.
 * - Supports the default MVC error page.
 * References:
 * Microsoft. (n.d.). ASP.NET Core MVC overview. https://learn.microsoft.com/en-us/aspnet/core/mvc/
 */

namespace ProcurementManagementSystem.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
