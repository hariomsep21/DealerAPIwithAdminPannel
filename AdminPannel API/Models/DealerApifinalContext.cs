using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdminPannel_API.Models;

public partial class DealerApifinalContext : DbContext
{
    public DealerApifinalContext()
    {
    }

    public DealerApifinalContext(DbContextOptions<DealerApifinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountDetailstbl> AccountDetailstbls { get; set; }

    public virtual DbSet<BankDetail> BankDetails { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CustomerSupporttbl> CustomerSupporttbls { get; set; }

    public virtual DbSet<Notificationstbl> Notificationstbls { get; set; }

    public virtual DbSet<OrderStockAuditstbl> OrderStockAuditstbls { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<ProcDetail> ProcDetails { get; set; }

    public virtual DbSet<ProcurementFilter> ProcurementFilters { get; set; }

    public virtual DbSet<ProfileInformationtbl> ProfileInformationtbls { get; set; }

    public virtual DbSet<PvAggregatorstbl> PvAggregatorstbls { get; set; }

    public virtual DbSet<PvNewCarDealerstbl> PvNewCarDealerstbls { get; set; }

    public virtual DbSet<PvOpenMarketstbl> PvOpenMarketstbls { get; set; }

    public virtual DbSet<PvaMaketbl> PvaMaketbls { get; set; }

    public virtual DbSet<PvaModeltbl> PvaModeltbls { get; set; }

    public virtual DbSet<PvaVarianttbl> PvaVarianttbls { get; set; }

    public virtual DbSet<PvaYearOfRegtbl> PvaYearOfRegtbls { get; set; }

    public virtual DbSet<RegisterAddress> RegisterAddresses { get; set; }

    public virtual DbSet<Statetbl> Statetbls { get; set; }

    public virtual DbSet<StockAudit> StockAudits { get; set; }

    public virtual DbSet<StockAuditPurposestbl> StockAuditPurposestbls { get; set; }

    public virtual DbSet<Userstbl> Userstbls { get; set; }

    public virtual DbSet<VehicleRecord> VehicleRecords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=EAT-LTP101;Database=DealerAPIFinal;User ID=sa;Password=password;Encrypt=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountDetailstbl>(entity =>
        {
            entity.ToTable("AccountDetailstbl");

            entity.HasIndex(e => e.UserInfoId, "IX_AccountDetailstbl_UserInfoId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountNumber).HasMaxLength(15);
            entity.Property(e => e.BankName).HasMaxLength(55);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(12)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.Name).HasMaxLength(20);

            entity.HasOne(d => d.UserInfo).WithMany(p => p.AccountDetailstbls).HasForeignKey(d => d.UserInfoId);
        });

        modelBuilder.Entity<BankDetail>(entity =>
        {
            entity.HasKey(e => e.RepaymentDetailId);

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(20)
                .HasColumnName("IFSCCode");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Cars_UserId");

            entity.Property(e => e.CarId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Cars).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<CustomerSupporttbl>(entity =>
        {
            entity.ToTable("CustomerSupporttbl");
        });

        modelBuilder.Entity<Notificationstbl>(entity =>
        {
            entity.ToTable("Notificationstbl");

            entity.HasIndex(e => e.UserInfoId, "IX_Notificationstbl_UserInfoId");

            entity.HasOne(d => d.UserInfo).WithMany(p => p.Notificationstbls).HasForeignKey(d => d.UserInfoId);
        });

        modelBuilder.Entity<OrderStockAuditstbl>(entity =>
        {
            entity.ToTable("Order_StockAuditstbl");

            entity.HasIndex(e => e.StockAuditPurposeId, "IX_Order_StockAuditstbl_StockAudit_PurposeId");

            entity.Property(e => e.StockAuditPurposeId).HasColumnName("StockAudit_PurposeId");

            entity.HasOne(d => d.StockAuditPurpose).WithMany(p => p.OrderStockAuditstbls).HasForeignKey(d => d.StockAuditPurposeId);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.HasIndex(e => e.BankId, "IX_Payment_BankId");

            entity.HasIndex(e => e.CarId, "IX_Payment_CarId");

            entity.Property(e => e.AmountDue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Amount_Due");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FacilityAvailed)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Facility_Availed");
            entity.Property(e => e.InvoiceCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Invoice_Charges");
            entity.Property(e => e.PaymentProofImg).HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProcessingCharges).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Bank).WithMany(p => p.Payments).HasForeignKey(d => d.BankId);

            entity.HasOne(d => d.Car).WithMany(p => p.Payments).HasForeignKey(d => d.CarId);
        });

        modelBuilder.Entity<ProcDetail>(entity =>
        {
            entity.ToTable("procDetails");

            entity.HasIndex(e => e.FilterId, "IX_procDetails_FilterId");

            entity.HasIndex(e => e.PayId, "IX_procDetails_PayId");

            entity.Property(e => e.PurchasedAmount).HasColumnName("Purchased_Amount");

            entity.HasOne(d => d.Filter).WithMany(p => p.ProcDetails).HasForeignKey(d => d.FilterId);

            entity.HasOne(d => d.Pay).WithMany(p => p.ProcDetails).HasForeignKey(d => d.PayId);
        });

        modelBuilder.Entity<ProcurementFilter>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ProfileInformationtbl>(entity =>
        {
            entity.ToTable("ProfileInformationtbl");

            entity.HasIndex(e => e.UserInfoId, "IX_ProfileInformationtbl_UserInfoId");

            entity.Property(e => e.AlternativeNumber).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ContactNumber).HasMaxLength(12);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ResidenceAddress).HasMaxLength(50);
            entity.Property(e => e.ShopAddress).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.UserInfo).WithMany(p => p.ProfileInformationtbls).HasForeignKey(d => d.UserInfoId);
        });

        modelBuilder.Entity<PvAggregatorstbl>(entity =>
        {
            entity.ToTable("PV_Aggregatorstbl");

            entity.HasIndex(e => e.MakeId, "IX_PV_Aggregatorstbl_MakeId");

            entity.HasIndex(e => e.ModelId, "IX_PV_Aggregatorstbl_ModelId");

            entity.HasIndex(e => e.UserInfoId, "IX_PV_Aggregatorstbl_UserInfoId");

            entity.HasIndex(e => e.VariantId, "IX_PV_Aggregatorstbl_VariantId");

            entity.HasIndex(e => e.YearOfRegistration, "IX_PV_Aggregatorstbl_YearOfRegistration");

            entity.Property(e => e.Rcavailable).HasColumnName("RCAvailable");

            entity.HasOne(d => d.Make).WithMany(p => p.PvAggregatorstbls).HasForeignKey(d => d.MakeId);

            entity.HasOne(d => d.Model).WithMany(p => p.PvAggregatorstbls).HasForeignKey(d => d.ModelId);

            entity.HasOne(d => d.UserInfo).WithMany(p => p.PvAggregatorstbls).HasForeignKey(d => d.UserInfoId);

            entity.HasOne(d => d.Variant).WithMany(p => p.PvAggregatorstbls).HasForeignKey(d => d.VariantId);

            entity.HasOne(d => d.YearOfRegistrationNavigation).WithMany(p => p.PvAggregatorstbls).HasForeignKey(d => d.YearOfRegistration);
        });

        modelBuilder.Entity<PvNewCarDealerstbl>(entity =>
        {
            entity.ToTable("PV_NewCarDealerstbl");

            entity.HasIndex(e => e.UserInfoId, "IX_PV_NewCarDealerstbl_UserInfoId");

            entity.Property(e => e.PictOfOrginalRc).HasColumnName("PictOfOrginalRC");

            entity.HasOne(d => d.UserInfo).WithMany(p => p.PvNewCarDealerstbls).HasForeignKey(d => d.UserInfoId);
        });

        modelBuilder.Entity<PvOpenMarketstbl>(entity =>
        {
            entity.ToTable("PV_OpenMarketstbl");

            entity.HasIndex(e => e.UserInfoId, "IX_PV_OpenMarketstbl_UserInfoId");

            entity.Property(e => e.PictureOfOriginalRc).HasColumnName("PictureOfOriginalRC");
            entity.Property(e => e.SellerContactNumber).HasMaxLength(12);
            entity.Property(e => e.SellerPan).HasColumnName("SellerPAN");

            entity.HasOne(d => d.UserInfo).WithMany(p => p.PvOpenMarketstbls).HasForeignKey(d => d.UserInfoId);
        });

        modelBuilder.Entity<PvaMaketbl>(entity =>
        {
            entity.HasKey(e => e.MakeId);

            entity.ToTable("PVA_Maketbl");
        });

        modelBuilder.Entity<PvaModeltbl>(entity =>
        {
            entity.HasKey(e => e.ModelId);

            entity.ToTable("PVA_Modeltbl");
        });

        modelBuilder.Entity<PvaVarianttbl>(entity =>
        {
            entity.HasKey(e => e.VariantId);

            entity.ToTable("PVA_Varianttbl");
        });

        modelBuilder.Entity<PvaYearOfRegtbl>(entity =>
        {
            entity.HasKey(e => e.YearId);

            entity.ToTable("PVA_YearOfRegtbl");
        });

        modelBuilder.Entity<RegisterAddress>(entity =>
        {
            entity.HasIndex(e => e.IdU, "IX_RegisterAddresses_IdU");

            entity.Property(e => e.AddressType).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.IdUNavigation).WithMany(p => p.RegisterAddresses).HasForeignKey(d => d.IdU);
        });

        modelBuilder.Entity<Statetbl>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("Statetbl");

            entity.Property(e => e.StateCode).HasMaxLength(14);
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<StockAudit>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_StockAudits_CarId");

            entity.Property(e => e.Image1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("image1");
            entity.Property(e => e.Image2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("image2");
            entity.Property(e => e.Image3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("image3");
            entity.Property(e => e.Varified)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("varified");

            entity.HasOne(d => d.Car).WithMany(p => p.StockAudits).HasForeignKey(d => d.CarId);
        });

        modelBuilder.Entity<StockAuditPurposestbl>(entity =>
        {
            entity.ToTable("StockAudit_Purposestbl");
        });

        modelBuilder.Entity<Userstbl>(entity =>
        {
            entity.ToTable("Userstbl");

            entity.HasIndex(e => e.Sid, "IX_Userstbl_SId");

            entity.Property(e => e.Otp).HasColumnName("OTP");
            entity.Property(e => e.Otpexpiry)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')")
                .HasColumnName("OTPExpiry");
            entity.Property(e => e.Phone).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Sid).HasColumnName("SId");

            entity.HasOne(d => d.SidNavigation).WithMany(p => p.Userstbls).HasForeignKey(d => d.Sid);
        });

        modelBuilder.Entity<VehicleRecord>(entity =>
        {
            entity.HasIndex(e => e.Cid, "IX_VehicleRecords_CId");

            entity.Property(e => e.Cid).HasColumnName("CId");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.VehicleRecords).HasForeignKey(d => d.Cid);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
