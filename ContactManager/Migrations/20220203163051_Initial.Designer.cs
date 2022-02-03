﻿// <auto-generated />
using System;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManager.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20220203163051_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactManager.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categoriy");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryID = 1,
                            DateAdded = new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(513),
                            Email = "frodo@gomain.ca",
                            Firstname = "Frodo",
                            Lastname = "Baggings",
                            Phone = "416-123-1233"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryID = 1,
                            DateAdded = new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(539),
                            Email = "frodo@gomain.ca",
                            Firstname = "FPI",
                            Lastname = "Baggings",
                            Phone = "416-123-1233"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryID = 2,
                            DateAdded = new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(541),
                            Email = "frodo@gomain.ca",
                            Firstname = "ABC",
                            Lastname = "Baggings",
                            Phone = "416-123-1233"
                        },
                        new
                        {
                            ContactId = 4,
                            CategoryID = 3,
                            DateAdded = new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(543),
                            Email = "frodo@gomain.ca",
                            Firstname = "CFH",
                            Lastname = "Baggings",
                            Phone = "416-123-1233"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.HasOne("ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
