
using ALENGINE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ALENGINE.Data;

public class ALENGINEContext : IdentityDbContext<IdentityUser>
{
    public ALENGINEContext(DbContextOptions<ALENGINEContext> options)
        : base(options)
    {
    }
    public DbSet<Members> Members { get; set; }
    public DbSet<InitialPayment> InitialPayments { get; set; }
    public DbSet <PatientInformation> PatientInformations { get; set; }
    public DbSet <VitalInfo> VitalInfos { get; set; }
    public DbSet<Consulting> Consultings { get; set; }
    public DbSet<Inventory>  Inventories { get; set; }
    public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
    public DbSet<ANC> ANCs { get; set; }
    public DbSet <ANCHistory> ANCHistories { get; set; }
    public DbSet<DeliveryNote> DeliveryNotes { get; set; }
    public DbSet<Diagnose> Diagnoses { get; set; }
    public DbSet<Central> Centrals { get; set; }
    public DbSet<MedicineList> MedicineLists { get; set; }
    public DbSet<Postnatal> Postnatals { get; set; }
    public DbSet<DiagnosisCategory> DiagnosisCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
