﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoyagerSQLAPI.Data;

#nullable disable

namespace VoyagerSQLAPI.Migrations
{
    [DbContext(typeof(VoyagerDbContext))]
    partial class VoyagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VoyagerSQLAPI.Models.AppLogs.AppLogsData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("FormaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LogsNumber")
                        .HasColumnType("int");

                    b.Property<int>("ModuliId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("appLogs");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.DB.output", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userid"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid");

                    b.ToTable("output");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Filters.OutPutFilters", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelPrice")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("filtersout");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Hotel.HotelAndRoomsProc.HotelAndRooms_proc", b =>
                {
                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelPrice")
                        .HasColumnType("int");

                    b.Property<string>("RoomDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomsId")
                        .HasColumnType("int");

                    b.ToTable("hotelandrooms");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Hotel.HotelDatas", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelPrice")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("hotelDatas");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Hotel.HotelDetailsProc.HotelDetailsProc_Out", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("hotelproc");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Hotel.HotelReserved", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("isFree")
                        .HasColumnType("bit");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("reservationH");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Hotel.HotelRooms", b =>
                {
                    b.Property<int>("RoomsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomsId"), 1L, 1);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("RoomDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomsId");

                    b.ToTable("hotelrooms");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Packages.PackagesDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Packagesid")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("packagedetails");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.PackagesData.PackagesData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<int>("flightId")
                        .HasColumnType("int");

                    b.Property<int>("hotelid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("insertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("packagesDatas");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.PaymentGateWay.PaymentDetails", b =>
                {
                    b.Property<Guid>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("adminApproved")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hotelId")
                        .HasColumnType("int");

                    b.Property<bool>("isDone")
                        .HasColumnType("bit");

                    b.Property<int>("roomid")
                        .HasColumnType("int");

                    b.Property<int>("ticketid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.ToTable("paymentdata");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.PaymentGateWay.SuccessPaymentGateAway", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("adminApproved")
                        .HasColumnType("bit");

                    b.Property<string>("hotelid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("inserteddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("paymentSucc");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.TeamMembers.TeamMembersData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembersDatas");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Tickets.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("destination");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Tickets.FlightData", b =>
                {
                    b.Property<int>("FlightNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightNumber"), 1L, 1);

                    b.Property<string>("AirCraftName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FlightPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TailNumber")
                        .HasColumnType("int");

                    b.HasKey("FlightNumber");

                    b.ToTable("FlightsDatas");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Tickets.TicketDetail_Proc.TicketData_OUT", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirCraftName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FlightNumber")
                        .HasColumnType("int");

                    b.Property<string>("HotelDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelPrice")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MAXPassagerNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int?>("TailNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("TicketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TicketNumber")
                        .HasColumnType("int");

                    b.ToTable("ticketsOut");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Tickets.TicketDetails", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("FlightPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.ToTable("TicketsDetails");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.TripProcedure.outputTrip", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirCraftName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("int");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TailNumber")
                        .HasColumnType("int");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("outputTrip");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.Users.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("VoyagerSQLAPI.Models.VoyagerToBeDeleted", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Completed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoyagerType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("voyagers");
                });
#pragma warning restore 612, 618
        }
    }
}
