﻿// <auto-generated />
using System;
using HospitalSystem.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalSystem.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalSystem.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "d3eb6526-b347-4e01-af9d-f2fc02a9401a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "06968d47-5fe8-4183-bb32-d6c36573f95a",
                            DateOfBirth = new DateTime(2003, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            Gender = 0,
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELCUBseYpD1x6IhPbj8lkVHArdD1SLuBRWer8oyGtQKeI2HBnjw9GIapiew/EK+G7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cbdb00a8-2cd4-40d4-bc9c-250dc2d3ea89",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        });
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Appointment", b =>
                {
                    b.Property<string>("AppointmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeptId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeptId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentID");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("Appointment", (string)null);
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Departments", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnosisDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("MedicalRecord", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f356a8e0-2b8d-4550-a650-4c8cd6e1353d",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = "60db17c9-029e-4fd2-99a5-bcb3c4c89715",
                            Name = "Nurse",
                            NormalizedName = "NURSE"
                        },
                        new
                        {
                            Id = "c8f5b7f6-8f61-4aa1-a276-94b75030a713",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        },
                        new
                        {
                            Id = "fbeded90-56ec-4f31-be8e-fe2eafc8608c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d3eb6526-b347-4e01-af9d-f2fc02a9401a",
                            RoleId = "fbeded90-56ec-4f31-be8e-fe2eafc8608c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Doctor", b =>
                {
                    b.HasBaseType("HospitalSystem.Core.Entities.ApplicationUser");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Doctor", (string)null);
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Nurse", b =>
                {
                    b.HasBaseType("HospitalSystem.Core.Entities.ApplicationUser");

                    b.Property<string>("DepartmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DoctorID")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Nurse", (string)null);
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Patient", b =>
                {
                    b.HasBaseType("HospitalSystem.Core.Entities.ApplicationUser");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Appointment", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.Departments", "Department")
                        .WithMany("Appointments")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("HospitalSystem.Core.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalSystem.Core.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.MedicalRecord", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.Departments", null)
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DepartmentsId");

                    b.HasOne("HospitalSystem.Core.Entities.Doctor", "Doctor")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalSystem.Core.Entities.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Doctor", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.Departments", "Department")
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("HospitalSystem.Core.Entities.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Nurse", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.Departments", "Departments")
                        .WithMany("Nurses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalSystem.Core.Entities.Doctor", "Doctor")
                        .WithMany("Nurses")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("HospitalSystem.Core.Entities.Nurse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Patient", b =>
                {
                    b.HasOne("HospitalSystem.Core.Entities.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("HospitalSystem.Core.Entities.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Departments", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");

                    b.Navigation("MedicalRecords");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("HospitalSystem.Core.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
