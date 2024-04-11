﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace BlibT.Server.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240401215529_Users")]
    partial class Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "David Johnson"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Emma Brown"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Michael Davis"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Sophia Miller"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Daniel Wilson"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Olivia Moore"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Ethan Lee"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Ava Anderson"
                        });
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Favorits")
                        .HasColumnType("int");

                    b.Property<int?>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Pages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Da Vinci Code",
                            Views = 10
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Dune",
                            Views = 10
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Pride and Prejudice",
                            Views = 10
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Girl with the Dragon Tattoo",
                            Views = 10
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Harry Potter and the Sorcerer's Stone",
                            Views = 10
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Great Gatsby",
                            Views = 10
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 7,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Steve Jobs",
                            Views = 10
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 8,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Hobbit",
                            Views = 10
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 9,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "It",
                            Views = 10
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 10,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Romeo and Juliet",
                            Views = 10
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 2,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Hound of the Baskervilles",
                            Views = 10
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 2,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Neuromancer",
                            Views = 10
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 5,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Sense and Sensibility",
                            Views = 10
                        },
                        new
                        {
                            Id = 14,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Girl Who Played with Fire",
                            Views = 10
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 5,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Harry Potter and the Chamber of Secrets",
                            Views = 10
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 6,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "To Kill a Mockingbird",
                            Views = 10
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 7,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Einstein: His Life and Universe",
                            Views = 10
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 8,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Lord of the Rings",
                            Views = 10
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 3,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "The Shining",
                            Views = 10
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 10,
                            Description = "Some text",
                            Favorits = 10,
                            Likes = 10,
                            Pages = "[\"text\",\"from\",\"book\"]",
                            ProductImageName = "default.jpg",
                            Title = "Macbeth",
                            Views = 10
                        });
                });

            modelBuilder.Entity("Entities.Models.BookGenre", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            BookId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            BookId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = 3
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = 4
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = 5
                        });
                });

            modelBuilder.Entity("Entities.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Historical Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("Entities.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.HasOne("Entities.Models.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("Entities.Models.BookGenre", b =>
                {
                    b.HasOne("Entities.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
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
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
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

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("Entities.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });
#pragma warning restore 612, 618
        }
    }
}