using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HostelManagementApp.Models;

public partial class HostelContext : DbContext
{
    public HostelContext()
    {
    }

    public HostelContext(DbContextOptions<HostelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Hostel> Hostels { get; set; }

    public virtual DbSet<HostelLocation> HostelLocations { get; set; }

    public virtual DbSet<Lessor> Lessors { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.ToTable("Account");

            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.ToTable("Bill");

            entity.Property(e => e.BillId).HasColumnName("bill_ID");
            entity.Property(e => e.BillStatus).HasColumnName("billStatus");
            entity.Property(e => e.CreatedBillDate)
                .HasColumnType("date")
                .HasColumnName("createdBillDate");
            entity.Property(e => e.DateOfPayment)
                .HasColumnType("date")
                .HasColumnName("dateOfPayment");
            entity.Property(e => e.ElectricityKwh).HasColumnName("electricity (Kwh)");
            entity.Property(e => e.GarbageCollection).HasColumnName("Garbage collection");
            entity.Property(e => e.Internet).HasColumnName("internet");
            entity.Property(e => e.RoomId).HasColumnName("roomID");
            entity.Property(e => e.WaterM3).HasColumnName("water (m3)");

            entity.HasOne(d => d.Room).WithMany(p => p.Bills)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bill_Room");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Cccd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cccd");
            entity.Property(e => e.CheckInDate)
                .HasColumnType("date")
                .HasColumnName("checkIn_Date");
            entity.Property(e => e.CheckoutDate)
                .HasColumnType("date")
                .HasColumnName("checkout_Date");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .HasColumnName("customerName");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PlaceOfOrigin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("placeOfOrigin");
            entity.Property(e => e.RoomId).HasColumnName("roomID");

            entity.HasOne(d => d.Room).WithMany(p => p.Customers)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Room");
        });

        modelBuilder.Entity<Hostel>(entity =>
        {
            entity.ToTable("Hostel");

            entity.Property(e => e.HostelId).HasColumnName("hostelID");
            entity.Property(e => e.HostelName)
                .HasMaxLength(250)
                .HasColumnName("hostelName");
            entity.Property(e => e.LessorId).HasColumnName("lessorID");
            entity.Property(e => e.LocationId).HasColumnName("locationID");

            entity.HasOne(d => d.Lessor).WithMany(p => p.Hostels)
                .HasForeignKey(d => d.LessorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hostel_Lessor");

            entity.HasOne(d => d.Location).WithMany(p => p.Hostels)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hostel_HostelLocation");
        });

        modelBuilder.Entity<HostelLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("HostelLocation");

            entity.Property(e => e.LocationId).HasColumnName("locationID");
            entity.Property(e => e.LocationDetail)
                .HasMaxLength(255)
                .HasColumnName("locationDetail");
        });

        modelBuilder.Entity<Lessor>(entity =>
        {
            entity.ToTable("Lessor");

            entity.Property(e => e.LessorId).HasColumnName("lessorID");
            entity.Property(e => e.Cccd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cccd");
            entity.Property(e => e.LessorDob)
                .HasColumnType("date")
                .HasColumnName("lessorDOB");
            entity.Property(e => e.LessorGender).HasColumnName("lessorGender");
            entity.Property(e => e.LessorName)
                .HasMaxLength(250)
                .HasColumnName("lessorName");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Lessors)
                .HasForeignKey(d => d.Username)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessor_Account");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.RoomId).HasColumnName("roomID");
            entity.Property(e => e.HostelId).HasColumnName("hostelID");
            entity.Property(e => e.RoomNumber).HasColumnName("roomNumber");
            entity.Property(e => e.RoomPrice).HasColumnName("roomPrice");
            entity.Property(e => e.RoomType)
                .HasMaxLength(50)
                .HasColumnName("roomType");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Hostel).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HostelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Room_Hostel");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");

            entity.Property(e => e.ServiceId).HasColumnName("serviceID");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(250)
                .HasColumnName("serviceName");
            entity.Property(e => e.ServicePrice).HasColumnName("servicePrice");

            entity.HasMany(d => d.Rooms).WithMany(p => p.Services)
                .UsingEntity<Dictionary<string, object>>(
                    "RoomService",
                    r => r.HasOne<Room>().WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Room_Service_Room"),
                    l => l.HasOne<Service>().WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Room_Service_Service"),
                    j =>
                    {
                        j.HasKey("ServiceId", "RoomId");
                        j.ToTable("Room_Service");
                        j.IndexerProperty<int>("ServiceId").HasColumnName("serviceID");
                        j.IndexerProperty<int>("RoomId").HasColumnName("roomID");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
