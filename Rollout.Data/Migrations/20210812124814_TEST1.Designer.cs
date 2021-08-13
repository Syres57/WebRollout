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
    [Migration("20210812124814_TEST1")]
    partial class TEST1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
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

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("StreetAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

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

                    b.ToTable("Domain");
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

                    b.ToTable("StorageLocation");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStationState", b =>
                {
                    b.Property<string>("WorkStationStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkStationStateId");

                    b.ToTable("WorkStationState");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStations", b =>
                {
                    b.Property<int>("WorkStationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BatteryId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("DomainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EmissionsReport")
                        .HasColumnType("datetime2");

                    b.Property<string>("Serialnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StorageLocationLocationId")
                        .HasColumnType("int");

                    b.Property<int>("Ticketnumber")
                        .HasColumnType("int");

                    b.Property<string>("WorkStationStateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("WorkStepsStepId")
                        .HasColumnType("int");

                    b.HasKey("WorkStationId");

                    b.HasIndex("BatteryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DomainId");

                    b.HasIndex("StorageLocationLocationId");

                    b.HasIndex("WorkStationStateId");

                    b.HasIndex("WorkStepsStepId");

                    b.ToTable("WorkStations");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkSteps", b =>
                {
                    b.Property<int>("StepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxDuration")
                        .HasColumnType("int");

                    b.Property<int>("MinDuration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StepId");

                    b.ToTable("WorkSteps");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.WorkStations", b =>
                {
                    b.HasOne("Rollout.Data.EntityModels.Battery", "Battery")
                        .WithMany()
                        .HasForeignKey("BatteryId");

                    b.HasOne("Rollout.Data.EntityModels.Customer", "customer")
                        .WithMany("WorkStations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Rollout.Data.EntityModels.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("Rollout.Data.EntityModels.StorageLocation", "StorageLocation")
                        .WithMany()
                        .HasForeignKey("StorageLocationLocationId");

                    b.HasOne("Rollout.Data.EntityModels.WorkStationState", "WorkStationState")
                        .WithMany()
                        .HasForeignKey("WorkStationStateId");

                    b.HasOne("Rollout.Data.EntityModels.WorkSteps", "WorkSteps")
                        .WithMany()
                        .HasForeignKey("WorkStepsStepId");

                    b.Navigation("Battery");

                    b.Navigation("customer");

                    b.Navigation("Domain");

                    b.Navigation("StorageLocation");

                    b.Navigation("WorkStationState");

                    b.Navigation("WorkSteps");
                });

            modelBuilder.Entity("Rollout.Data.EntityModels.Customer", b =>
                {
                    b.Navigation("WorkStations");
                });
#pragma warning restore 612, 618
        }
    }
}
