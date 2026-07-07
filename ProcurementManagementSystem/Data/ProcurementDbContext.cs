using Microsoft.EntityFrameworkCore;
using ProcurementTrackingTool.Models;

namespace ProcurementTrackingTool.Data;

public class ProcurementDbContext : DbContext
{
    public ProcurementDbContext(DbContextOptions<ProcurementDbContext> options)
        : base(options)
    {
    }

    public DbSet<PurchaseRequest> PurchaseRequests { get; set; }

    public DbSet<Vendor> Vendors { get; set; }
}