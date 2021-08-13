﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rollout.Data;

namespace Rollout.Data.Migrations
{
    [DbContext(typeof(RolloutDbContext))]
    [Migration("20210713114556_changed_model")]
    partial class changed_model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rollout.Data.EntityModels.Battery", b =>
                {
                    b.Property<int>("BatteryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatteryChange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChargeDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BatteryId");

                    b.ToTable("Battery");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("StreetAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkStationId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("OrderId");

                    b.HasIndex("WorkStationId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.Domain", b =>
                {
                    b.Property<int>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DomainId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ticketnumber")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.StorageLocation", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("StorageLocations");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStation", b =>
                {
                    b.Property<int>("WorkStationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BatteryId")
                        .HasColumnType("int");

                    b.Property<int?>("DomainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EmissionsReport")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Serialnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StorageLocationLocationId")
                        .HasColumnType("int");

                    b.Property<string>("WorkStationStateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WorkStationId");

                    b.HasIndex("BatteryId");

                    b.HasIndex("DomainId");

                    b.HasIndex("OrderId");

                    b.HasIndex("StorageLocationLocationId");

                    b.HasIndex("WorkStationStateId");

                    b.ToTable("WorkStations");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStationState", b =>
                {
                    b.Property<string>("WorkStationStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkStationStateId");

                    b.ToTable("WorkStationStates");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.Customer", b =>
                {
                    b.HasOne("Rollout.Data.EntityModels.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("Rollout.Data.EntityModels.WorkStation", "workStation")
                        .WithMany()
                        .HasForeignKey("WorkStationId");

                    b.Navigation("order");

                    b.Navigation("workStation");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStation", b =>
                {
                    b.HasOne("Rollout.Data.EntityModels.Battery", "Battery")
                        .WithMany()
                        .HasForeignKey("BatteryId");

                    b.HasOne("Rollout.Data.EntityModels.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("Rollout.Data.EntityModels.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("Rollout.Data.EntityModels.StorageLocation", "StorageLocation")
                        .WithMany()
                        .HasForeignKey("StorageLocationLocationId");

                    b.HasOne("Rollout.Data.EntityModels.WorkStationState", "WorkStationState")
                        .WithMany()
                        .HasForeignKey("WorkStationStateId");

                    b.Navigation("Battery");

                    b.Navigation("Domain");

                    b.Navigation("Order");

                    b.Navigation("StorageLocation");

                    b.Navigation("WorkStationState");
                });
#pragma warning restore 612, 618
        }
    }
}
