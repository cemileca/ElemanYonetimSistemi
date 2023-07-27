﻿// <auto-generated />
using System;
using ElemanYonetimSistemi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ElemanYonetimSistemi.Persistence.Migrations
{
    [DbContext(typeof(ElemanYonetimSistemiDbContext))]
    [Migration("20230727180834_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BreakTimeEmployee", b =>
                {
                    b.Property<int>("BreakTimesID")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeesID")
                        .HasColumnType("integer");

                    b.HasKey("BreakTimesID", "EmployeesID");

                    b.HasIndex("EmployeesID");

                    b.ToTable("BreakTimeEmployee");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountryID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryShirtName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ZipCode")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.District", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("CityID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DistrictDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.FullAdress", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("CityID")
                        .HasColumnType("integer");

                    b.Property<int>("CountryID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DistrictID")
                        .HasColumnType("integer");

                    b.Property<string>("FullAdressDescrition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullAdressName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PersonalID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("PersonalID");

                    b.ToTable("FullAdress");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Common.Personal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IndividualNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<int?>("TasksID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("TasksID");

                    b.ToTable("Personals");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.BreakTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("BreakName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.ToTable("BreakTime");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DepartmanName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DepartmanSeniorID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("DepartmanSeniorID");

                    b.ToTable("Departman");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DepartmanID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndOfWork")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PersonalID")
                        .HasColumnType("integer");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ScoreOfEmployee")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartOfWork")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("DepartmanID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Tasks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<string>("Respite")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TaskAuthorizedID")
                        .HasColumnType("integer");

                    b.Property<string>("TaskDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TaskAuthorizedID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<int?>("JobDepartmanID")
                        .HasColumnType("integer");

                    b.Property<string>("JobDescription")
                        .HasColumnType("text");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("JobDepartmanID");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("BreakTimeEmployee", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.BreakTime", null)
                        .WithMany()
                        .HasForeignKey("BreakTimesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.City", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Adresses.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.District", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Adresses.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.FullAdress", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Adresses.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Adresses.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Adresses.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Common.Personal", null)
                        .WithMany("FullAdresses")
                        .HasForeignKey("PersonalID");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("District");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Common.Personal", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Tasks", null)
                        .WithMany("Employee")
                        .HasForeignKey("TasksID");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", "DepartmanSenior")
                        .WithMany()
                        .HasForeignKey("DepartmanSeniorID");

                    b.Navigation("DepartmanSenior");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", "Departman")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmanID");

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Common.Personal", "Personal")
                        .WithMany()
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Tasks", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", null)
                        .WithMany("EmployeesTasks")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Common.Personal", "TaskAuthorized")
                        .WithMany()
                        .HasForeignKey("TaskAuthorizedID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskAuthorized");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Job", b =>
                {
                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", null)
                        .WithMany("Jobs")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", "JobDepartman")
                        .WithMany("Jobs")
                        .HasForeignKey("JobDepartmanID");

                    b.Navigation("JobDepartman");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Adresses.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Common.Personal", b =>
                {
                    b.Navigation("FullAdresses");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Departman", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Employee", b =>
                {
                    b.Navigation("EmployeesTasks");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("ElemanYonetimSistemi.Domain.Entities.Employee.Tasks", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
