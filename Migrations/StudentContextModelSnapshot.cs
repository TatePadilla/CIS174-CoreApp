﻿// <auto-generated />
using CIS174_CoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS174_CoreApp.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS174_CoreApp.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Alice",
                            Grade = "A",
                            LastName = "Johnson"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Bob",
                            Grade = "B",
                            LastName = "Smith"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Carl",
                            Grade = "C",
                            LastName = "Brown"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Dan",
                            Grade = "D",
                            LastName = "White"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
