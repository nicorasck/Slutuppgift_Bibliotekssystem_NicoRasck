﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Slutuppgift_Bibliotekssystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<int?>("BirthYear")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookAuthorID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Borrower", b =>
                {
                    b.Property<int>("BorrowerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowerID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BorrowerID");

                    b.ToTable("Borrowers");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Lending", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("BorrowerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanID");

                    b.HasIndex("BookID");

                    b.HasIndex("BorrowerID");

                    b.ToTable("Lendings");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.BookAuthor", b =>
                {
                    b.HasOne("Slutuppgift_Bibliotekssystem.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Slutuppgift_Bibliotekssystem.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Lending", b =>
                {
                    b.HasOne("Slutuppgift_Bibliotekssystem.Book", "Book")
                        .WithMany("Lendings")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Slutuppgift_Bibliotekssystem.Borrower", "Borrower")
                        .WithMany("Lendings")
                        .HasForeignKey("BorrowerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrower");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("Lendings");
                });

            modelBuilder.Entity("Slutuppgift_Bibliotekssystem.Borrower", b =>
                {
                    b.Navigation("Lendings");
                });
#pragma warning restore 612, 618
        }
    }
}
