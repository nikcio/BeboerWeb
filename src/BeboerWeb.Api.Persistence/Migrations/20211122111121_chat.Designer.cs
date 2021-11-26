﻿// <auto-generated />
using System;
using BeboerWeb.Api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211122111121_chat")]
    partial class chat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AddressProperty", b =>
                {
                    b.Property<int>("AddressesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("AddressesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("AddressProperty");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Bookings.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Bookings.BookingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingItems");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Bookings.BookingWindow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BookingWindows");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.EmployeeToTenantMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MessageText")
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("EmployeeToTenantMessages");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.InternalMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MessageText")
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("InternalMessages");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.TenantToEmployeeMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MessageText")
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("TenantToEmployeeMessages");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Documents.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Lease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Apartment")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Story")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Leases");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.LeasePeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LesseId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LesseId");

                    b.ToTable("LeasePeriods");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("BookingBookingItem", b =>
                {
                    b.Property<int>("BookingItemsId")
                        .HasColumnType("int");

                    b.Property<int>("BookingsId")
                        .HasColumnType("int");

                    b.HasKey("BookingItemsId", "BookingsId");

                    b.HasIndex("BookingsId");

                    b.ToTable("BookingBookingItem");
                });

            modelBuilder.Entity("BookingDocument", b =>
                {
                    b.Property<int>("BookingsId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentsId")
                        .HasColumnType("int");

                    b.HasKey("BookingsId", "DocumentsId");

                    b.HasIndex("DocumentsId");

                    b.ToTable("BookingDocument");
                });

            modelBuilder.Entity("BookingItemBookingWindow", b =>
                {
                    b.Property<int>("BookingItemsId")
                        .HasColumnType("int");

                    b.Property<int>("BookingWindowsId")
                        .HasColumnType("int");

                    b.HasKey("BookingItemsId", "BookingWindowsId");

                    b.HasIndex("BookingWindowsId");

                    b.ToTable("BookingItemBookingWindow");
                });

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("CompanyEmployee");
                });

            modelBuilder.Entity("CompanyProperty", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("CompanyProperty");
                });

            modelBuilder.Entity("DocumentLeasePeriod", b =>
                {
                    b.Property<int>("DocumentsId")
                        .HasColumnType("int");

                    b.Property<int>("LeasePeriodsId")
                        .HasColumnType("int");

                    b.HasKey("DocumentsId", "LeasePeriodsId");

                    b.HasIndex("LeasePeriodsId");

                    b.ToTable("DocumentLeasePeriod");
                });

            modelBuilder.Entity("EmployeeTenantToEmployeeMessage", b =>
                {
                    b.Property<int>("ReceiversId")
                        .HasColumnType("int");

                    b.Property<int>("TenantToEmployeeMessagesId")
                        .HasColumnType("int");

                    b.HasKey("ReceiversId", "TenantToEmployeeMessagesId");

                    b.HasIndex("TenantToEmployeeMessagesId");

                    b.ToTable("EmployeeTenantToEmployeeMessage");
                });

            modelBuilder.Entity("EmployeeToTenantMessageTenant", b =>
                {
                    b.Property<int>("EmployeeToTenantMessagesId")
                        .HasColumnType("int");

                    b.Property<int>("ReceiversId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeToTenantMessagesId", "ReceiversId");

                    b.HasIndex("ReceiversId");

                    b.ToTable("EmployeeToTenantMessageTenant");
                });

            modelBuilder.Entity("InternalMessageTenant", b =>
                {
                    b.Property<int>("ReceivedInternalMessagesId")
                        .HasColumnType("int");

                    b.Property<int>("ReceiversId")
                        .HasColumnType("int");

                    b.HasKey("ReceivedInternalMessagesId", "ReceiversId");

                    b.HasIndex("ReceiversId");

                    b.ToTable("InternalMessageTenant");
                });

            modelBuilder.Entity("LeasePeriodTenant", b =>
                {
                    b.Property<int>("LeasePeriodsId")
                        .HasColumnType("int");

                    b.Property<int>("TenantsId")
                        .HasColumnType("int");

                    b.HasKey("LeasePeriodsId", "TenantsId");

                    b.HasIndex("TenantsId");

                    b.ToTable("LeasePeriodTenant");
                });

            modelBuilder.Entity("AddressProperty", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Bookings.Booking", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", null)
                        .WithMany("Bookings")
                        .HasForeignKey("TenantId");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.EmployeeToTenantMessage", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.InternalMessage", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", "Sender")
                        .WithMany("SentInternalMessages")
                        .HasForeignKey("SenderId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.Chat.TenantToEmployeeMessage", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Lease", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", "Address")
                        .WithMany("Leases")
                        .HasForeignKey("AddressId");

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", "Property")
                        .WithMany("Lesses")
                        .HasForeignKey("PropertyId");

                    b.Navigation("Address");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.LeasePeriod", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Lease", "Lesse")
                        .WithMany("LessePeriods")
                        .HasForeignKey("LesseId");

                    b.Navigation("Lesse");
                });

            modelBuilder.Entity("BookingBookingItem", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Bookings.BookingItem", null)
                        .WithMany()
                        .HasForeignKey("BookingItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.Bookings.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookingDocument", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Bookings.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.Documents.Document", null)
                        .WithMany()
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookingItemBookingWindow", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Bookings.BookingItem", null)
                        .WithMany()
                        .HasForeignKey("BookingItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.Bookings.BookingWindow", null)
                        .WithMany()
                        .HasForeignKey("BookingWindowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyProperty", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentLeasePeriod", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Documents.Document", null)
                        .WithMany()
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.LeasePeriod", null)
                        .WithMany()
                        .HasForeignKey("LeasePeriodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeTenantToEmployeeMessage", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", null)
                        .WithMany()
                        .HasForeignKey("ReceiversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.Chat.TenantToEmployeeMessage", null)
                        .WithMany()
                        .HasForeignKey("TenantToEmployeeMessagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeToTenantMessageTenant", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Chat.EmployeeToTenantMessage", null)
                        .WithMany()
                        .HasForeignKey("EmployeeToTenantMessagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", null)
                        .WithMany()
                        .HasForeignKey("ReceiversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InternalMessageTenant", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.Chat.InternalMessage", null)
                        .WithMany()
                        .HasForeignKey("ReceivedInternalMessagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", null)
                        .WithMany()
                        .HasForeignKey("ReceiversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeasePeriodTenant", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.LeasePeriod", null)
                        .WithMany()
                        .HasForeignKey("LeasePeriodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", null)
                        .WithMany()
                        .HasForeignKey("TenantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", b =>
                {
                    b.Navigation("Leases");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Lease", b =>
                {
                    b.Navigation("LessePeriods");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", b =>
                {
                    b.Navigation("Lesses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("SentInternalMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
