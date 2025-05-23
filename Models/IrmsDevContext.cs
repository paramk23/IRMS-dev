using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Indent_Dev.Models;

public partial class IrmsDevContext : DbContext
{
    public IrmsDevContext()
    {
    }

    public IrmsDevContext(DbContextOptions<IrmsDevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Indent> Indents { get; set; }

    public virtual DbSet<IndentStatus> IndentStatuses { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Pu> Pus { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<Subunit> Subunits { get; set; }

    public virtual DbSet<TaSpoc> TaSpocs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =VSOLCHNSZ-02\\SQLEXPRESS;Initial Catalog=IRMS_Dev;Integrated Security=true;TrustServerCertificate=True",options =>options.EnableRetryOnFailure());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountName).HasName("PK__Account__98F1247D8B196573");

            entity.ToTable("Account");

            entity.Property(e => e.AccountName)
                .HasMaxLength(25)
                .HasColumnName("Account_Name");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryName).HasName("PK__Category__B35EB4181285687E");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(20)
                .HasColumnName("Category_Name");
            entity.Property(e => e.CategoryId).HasColumnName("Category_Id");
        });

        modelBuilder.Entity<Indent>(entity =>
        {
            entity.HasKey(e => e.IndentNumber).HasName("PK__Indents__4F7F424E39DC2864");

            entity.Property(e => e.IndentNumber)
                .HasMaxLength(35)
                .HasColumnName("Indent_Number");
            entity.Property(e => e.Account).HasMaxLength(25);
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.DateOfFulfillment).HasColumnName("Date_of_Fulfillment");
            entity.Property(e => e.DateOfRelease).HasColumnName("Date_of_Release");
            entity.Property(e => e.FyQuarter)
                .HasMaxLength(15)
                .HasColumnName("FY_Quarter");
            entity.Property(e => e.IndentStatus)
                .HasMaxLength(25)
                .HasColumnName("Indent_Status");
            entity.Property(e => e.IndentType)
                .HasMaxLength(15)
                .HasColumnName("Indent_Type");
            entity.Property(e => e.JL)
                .HasMaxLength(5)
                .HasColumnName("JL");
            entity.Property(e => e.Location).HasMaxLength(25);
            entity.Property(e => e.NumberOfSlots).HasColumnName("Number_of_slots");
            entity.Property(e => e.PU)
                .HasMaxLength(25)
                .HasColumnName("PU");
            entity.Property(e => e.Remarks).HasMaxLength(60);
            entity.Property(e => e.Role).HasMaxLength(35);
            entity.Property(e => e.SubCategory)
                .HasMaxLength(50)
                .HasColumnName("Sub_Category");
            entity.Property(e => e.Subunit).HasMaxLength(15);
            entity.Property(e => e.TaSpoc)
                .HasMaxLength(35)
                .HasColumnName("TA_SPOC");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.Account)
                .HasConstraintName("FK__Indents__Account__1332DBDC");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK__Indents__Categor__0D7A0286");

            entity.HasOne(d => d.IndentStatusNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.IndentStatus)
                .HasConstraintName("FK__Indents__Indent___123EB7A3");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.Location)
                .HasConstraintName("FK__Indents__Locatio__0F624AF8");

            entity.HasOne(d => d.PuNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.PU)
                .HasConstraintName("FK__Indents__PU__114A936A");

            entity.HasOne(d => d.SubCategoryNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.SubCategory)
                .HasConstraintName("FK__Indents__Sub_Cat__0E6E26BF");

            entity.HasOne(d => d.SubunitNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.Subunit)
                .HasConstraintName("FK__Indents__Subunit__10566F31");

            entity.HasOne(d => d.TaSpocNavigation).WithMany(p => p.Indents)
                .HasForeignKey(d => d.TaSpoc)
                .HasConstraintName("FK__Indents__TA_SPOC__14270015");
        });

        modelBuilder.Entity<IndentStatus>(entity =>
        {
            entity.HasKey(e => e.IndentStatus1).HasName("PK__Indent_S__B5DEB546B2A5803A");

            entity.ToTable("Indent_Status");

            entity.Property(e => e.IndentStatus1)
                .HasMaxLength(25)
                .HasColumnName("Indent_Status");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationName).HasName("PK__Location__859FEFA63A4D2DA3");

            entity.ToTable("Location");

            entity.Property(e => e.LocationName)
                .HasMaxLength(25)
                .HasColumnName("Location_Name");
        });

        modelBuilder.Entity<Pu>(entity =>
        {
            entity.HasKey(e => e.PuName).HasName("PK__PU__005CD055B7FD5D58");

            entity.ToTable("PU");

            entity.Property(e => e.PuName)
                .HasMaxLength(25)
                .HasColumnName("PU_Name");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.HasKey(e => e.SubCategoryName).HasName("pk_subcategoryname");

            entity.ToTable("Sub_Category");

            entity.Property(e => e.SubCategoryName)
                .HasMaxLength(50)
                .HasColumnName("Sub_Category_Name");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.SubCategories)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_Category");
        });

        modelBuilder.Entity<Subunit>(entity =>
        {
            entity.HasKey(e => e.SubunitName).HasName("PK__Subunit__A36C0CB3EC6A31DE");

            entity.ToTable("Subunit");

            entity.Property(e => e.SubunitName)
                .HasMaxLength(15)
                .HasColumnName("Subunit_Name");
        });

        modelBuilder.Entity<TaSpoc>(entity =>
        {
            entity.HasKey(e => e.TaSpocName).HasName("PK__TA_SPOC__3BFB0A681B452E14");

            entity.ToTable("TA_SPOC");

            entity.Property(e => e.TaSpocName)
                .HasMaxLength(35)
                .HasColumnName("TA_SPOC_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
