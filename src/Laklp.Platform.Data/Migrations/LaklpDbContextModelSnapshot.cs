﻿// <auto-generated />
using System;
using Laklp.Platform.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Laklp.Platform.Data.Migrations
{
    [DbContext(typeof(LaklpDbContext))]
    partial class LaklpDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Laklp.Platform.Data.Entities.CheckPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChallengeQuestion");

                    b.Property<int>("ChallengeType");

                    b.Property<int>("CheckPointStatus");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<Guid?>("InterventionId");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<bool>("Satisfied");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("InterventionId");

                    b.ToTable("CheckPoints","QualityAssurance");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CompanyLegalNumber");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<Guid?>("GeocoordinateId");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("GeocoordinateId");

                    b.ToTable("Companies","Places");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Delegation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<Guid?>("CompanyId");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<int>("DelegationType");

                    b.Property<string>("Description");

                    b.Property<Guid?>("GeocoordinateId");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("GeocoordinateId");

                    b.ToTable("Delegations","Places");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.DocumentaryResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CompanyId");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<int>("DocumentaryResourceType");

                    b.Property<Guid?>("EntityId");

                    b.Property<string>("Extension");

                    b.Property<bool>("IsEnabled");

                    b.Property<Guid?>("MaintenanceServiceId");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Properties");

                    b.Property<string>("S3Bucket");

                    b.Property<string>("S3Key");

                    b.Property<string>("S3Path");

                    b.Property<string>("S3Region");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("EntityId");

                    b.HasIndex("MaintenanceServiceId");

                    b.ToTable("DocumentaryResources","Documentation");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<Guid?>("ResponsibleId");

                    b.Property<Guid?>("WorksAtId");

                    b.Property<Guid?>("WorksForId");

                    b.HasKey("Id");

                    b.HasIndex("ResponsibleId");

                    b.HasIndex("WorksAtId");

                    b.HasIndex("WorksForId");

                    b.ToTable("Employees","HumanResources");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Entity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<Guid?>("GeocoordinateId");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("GeocoordinateId");

                    b.HasIndex("ParentId");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Geocoordinate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Geocoordinates","Miscellaneous");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Intervention", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<Guid?>("AssignedToId");

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<Guid?>("DelegationId");

                    b.Property<DateTime>("EndTime");

                    b.Property<Guid?>("EntityId");

                    b.Property<int>("EvaluationResult");

                    b.Property<int>("EvaluationStatus");

                    b.Property<Guid?>("GeocoordinateId");

                    b.Property<string>("InterventionDescription");

                    b.Property<Guid?>("MaintenanceServiceId");

                    b.Property<DateTime?>("Modified");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DelegationId");

                    b.HasIndex("EntityId");

                    b.HasIndex("GeocoordinateId");

                    b.HasIndex("MaintenanceServiceId");

                    b.ToTable("Interventions","QualityAssurance");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.MaintenanceService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<Guid?>("DelegationId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DelegationId");

                    b.ToTable("MaintenanceServices","QualityAssurance");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<Guid?>("CreatedById");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Surname1");

                    b.Property<string>("Surname2");

                    b.Property<string>("UserName");

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Users","Platform");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.TeamLead", b =>
                {
                    b.HasBaseType("Laklp.Platform.Data.Entities.Employee");

                    b.ToTable("TeamLeads","HumanResources");

                    b.HasDiscriminator().HasValue("TeamLead");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.CheckPoint", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Intervention", "Intervention")
                        .WithMany("CheckPoints")
                        .HasForeignKey("InterventionId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Company", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Geocoordinate", "Geocoordinate")
                        .WithMany()
                        .HasForeignKey("GeocoordinateId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Delegation", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.Company", "Company")
                        .WithMany("Delegations")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Geocoordinate", "Geocoordinate")
                        .WithMany()
                        .HasForeignKey("GeocoordinateId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.DocumentaryResource", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.Company")
                        .WithMany("DocumentaryResources")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Entity")
                        .WithMany("DocumentaryResources")
                        .HasForeignKey("EntityId");

                    b.HasOne("Laklp.Platform.Data.Entities.MaintenanceService")
                        .WithMany("DocumentaryResources")
                        .HasForeignKey("MaintenanceServiceId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Employee", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "User")
                        .WithOne("Role")
                        .HasForeignKey("Laklp.Platform.Data.Entities.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Laklp.Platform.Data.Entities.TeamLead", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleId");

                    b.HasOne("Laklp.Platform.Data.Entities.Delegation", "WorksAt")
                        .WithMany()
                        .HasForeignKey("WorksAtId");

                    b.HasOne("Laklp.Platform.Data.Entities.Company", "WorksFor")
                        .WithMany()
                        .HasForeignKey("WorksForId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Entity", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Geocoordinate", "Geocoordinate")
                        .WithMany()
                        .HasForeignKey("GeocoordinateId");

                    b.HasOne("Laklp.Platform.Data.Entities.Entity", "Parent")
                        .WithMany("Components")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Intervention", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.Employee", "AssignedTo")
                        .WithMany("Interventions")
                        .HasForeignKey("AssignedToId");

                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Delegation", "Delegation")
                        .WithMany()
                        .HasForeignKey("DelegationId");

                    b.HasOne("Laklp.Platform.Data.Entities.Entity", "Entity")
                        .WithMany("Interventions")
                        .HasForeignKey("EntityId");

                    b.HasOne("Laklp.Platform.Data.Entities.Geocoordinate", "Geocoordinate")
                        .WithMany()
                        .HasForeignKey("GeocoordinateId");

                    b.HasOne("Laklp.Platform.Data.Entities.MaintenanceService", "MaintenanceService")
                        .WithMany("Interventions")
                        .HasForeignKey("MaintenanceServiceId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.MaintenanceService", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Laklp.Platform.Data.Entities.Delegation")
                        .WithMany("MaintenanceServices")
                        .HasForeignKey("DelegationId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.User", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });
#pragma warning restore 612, 618
        }
    }
}
