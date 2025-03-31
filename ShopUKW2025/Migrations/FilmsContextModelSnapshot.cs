﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopUKW2025.DAL;

#nullable disable

namespace ShopUKW2025.Migrations
{
    [DbContext(typeof(FilmsContext))]
    partial class FilmsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopUKW2025.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Desc = "Filmy pełne dynamicznych scen i emocjonujących pościgów.",
                            Name = "Akcja"
                        },
                        new
                        {
                            CategoryId = 2,
                            Desc = "Filmy, które rozbawią Cię do łez.",
                            Name = "Komedia"
                        },
                        new
                        {
                            CategoryId = 3,
                            Desc = "Opowieści pełne emocji i głębokich przeżyć.",
                            Name = "Dramat"
                        },
                        new
                        {
                            CategoryId = 4,
                            Desc = "Filmy o przyszłości, technologii i podróżach kosmicznych.",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 5,
                            Desc = "Produkcje wywołujące strach i dreszcze.",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 6,
                            Desc = "Filmy o magicznych światach i niezwykłych stworzeniach.",
                            Name = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 7,
                            Desc = "Napięcie i zaskakujące zwroty akcji.",
                            Name = "Thriller"
                        },
                        new
                        {
                            CategoryId = 8,
                            Desc = "Filmy animowane dla dzieci i dorosłych.",
                            Name = "Animacja"
                        },
                        new
                        {
                            CategoryId = 9,
                            Desc = "Filmy oparte na faktach, edukacyjne i inspirujące.",
                            Name = "Dokumentalny"
                        },
                        new
                        {
                            CategoryId = 10,
                            Desc = "Historie miłosne pełne wzruszeń i emocji.",
                            Name = "Romans"
                        });
                });

            modelBuilder.Entity("ShopUKW2025.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            CategoryId = 1,
                            Desc = "Postapokaliptyczna akcja pełna pościgów.",
                            Director = "George Miller",
                            Poster = "plakat1.jpg",
                            Price = 29.99m,
                            Title = "Mad Max: Fury Road"
                        },
                        new
                        {
                            FilmId = 2,
                            CategoryId = 2,
                            Desc = "Grupa przyjaciół wpada w kłopoty po wieczorze kawalerskim.",
                            Director = "Todd Phillips",
                            Poster = "plakat2.jpg",
                            Price = 19.99m,
                            Title = "The Hangover"
                        },
                        new
                        {
                            FilmId = 3,
                            CategoryId = 3,
                            Desc = "Historia nadziei i przyjaźni w więzieniu.",
                            Director = "Frank Darabont",
                            Poster = "plakat3.jpg",
                            Price = 24.99m,
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            FilmId = 4,
                            CategoryId = 4,
                            Desc = "Podróż w głąb kosmosu w poszukiwaniu nowego domu dla ludzkości.",
                            Director = "Christopher Nolan",
                            Poster = "plakat4.jpg",
                            Price = 34.99m,
                            Title = "Interstellar"
                        },
                        new
                        {
                            FilmId = 5,
                            CategoryId = 5,
                            Desc = "Przerażająca historia nawiedzonego domu.",
                            Director = "James Wan",
                            Poster = "plakat5.jpg",
                            Price = 22.99m,
                            Title = "The Conjuring"
                        },
                        new
                        {
                            FilmId = 6,
                            CategoryId = 6,
                            Desc = "Początek epickiej podróży w świecie Śródziemia.",
                            Director = "Peter Jackson",
                            Poster = "plakat6.jpg",
                            Price = 39.99m,
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            FilmId = 7,
                            CategoryId = 7,
                            Desc = "Detektywi ścigają seryjnego mordercę inspirowanego siedmioma grzechami głównymi.",
                            Director = "David Fincher",
                            Poster = "plakat7.jpg",
                            Price = 27.99m,
                            Title = "Se7en"
                        },
                        new
                        {
                            FilmId = 8,
                            CategoryId = 8,
                            Desc = "Przygody ożywionych zabawek.",
                            Director = "John Lasseter",
                            Poster = "plakat8.jpg",
                            Price = 14.99m,
                            Title = "Toy Story"
                        },
                        new
                        {
                            FilmId = 9,
                            CategoryId = 9,
                            Desc = "Spektakularna podróż przez najpiękniejsze zakątki Ziemi.",
                            Director = "Alastair Fothergill",
                            Poster = "plakat9.jpg",
                            Price = 44.99m,
                            Title = "Planet Earth"
                        },
                        new
                        {
                            FilmId = 10,
                            CategoryId = 10,
                            Desc = "Poruszająca historia miłosna na przestrzeni lat.",
                            Director = "Nick Cassavetes",
                            Poster = "plakat10.jpg",
                            Price = 19.99m,
                            Title = "The Notebook"
                        },
                        new
                        {
                            FilmId = 11,
                            CategoryId = 1,
                            Desc = "Zemsta zabójcy na przestępczym świecie.",
                            Director = "Chad Stahelski",
                            Poster = "plakat11.jpg",
                            Price = 32.99m,
                            Title = "John Wick"
                        },
                        new
                        {
                            FilmId = 12,
                            CategoryId = 2,
                            Desc = "Nastoletnie przygody pełne humoru.",
                            Director = "Greg Mottola",
                            Poster = "plakat12.jpg",
                            Price = 16.99m,
                            Title = "Superbad"
                        },
                        new
                        {
                            FilmId = 13,
                            CategoryId = 3,
                            Desc = "Historia niezwykłego życia Forresta.",
                            Director = "Robert Zemeckis",
                            Poster = "plakat13.jpg",
                            Price = 26.99m,
                            Title = "Forrest Gump"
                        },
                        new
                        {
                            FilmId = 14,
                            CategoryId = 4,
                            Desc = "Kontynuacja kultowego sci-fi.",
                            Director = "Denis Villeneuve",
                            Poster = "plakat14.jpg",
                            Price = 37.99m,
                            Title = "Blade Runner 2049"
                        },
                        new
                        {
                            FilmId = 15,
                            CategoryId = 5,
                            Desc = "Mrożący krew w żyłach horror o Pennywise.",
                            Director = "Andy Muschietti",
                            Poster = "plakat15.jpg",
                            Price = 23.99m,
                            Title = "It"
                        },
                        new
                        {
                            FilmId = 16,
                            CategoryId = 6,
                            Desc = "Początek magicznej przygody Harry'ego Pottera.",
                            Director = "Chris Columbus",
                            Poster = "cube.jpg",
                            Price = 35.99m,
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            FilmId = 17,
                            CategoryId = 7,
                            Desc = "Zniknięcie żony prowadzi do mrocznych tajemnic.",
                            Director = "David Fincher",
                            Poster = "cube.jpg",
                            Price = 28.99m,
                            Title = "Gone Girl"
                        },
                        new
                        {
                            FilmId = 18,
                            CategoryId = 8,
                            Desc = "Przygody zielonego ogra.",
                            Director = "Andrew Adamson, Vicky Jenson",
                            Poster = "cube.jpg",
                            Price = 18.99m,
                            Title = "Shrek"
                        },
                        new
                        {
                            FilmId = 19,
                            CategoryId = 9,
                            Desc = "Dokument o wędrówce pingwinów cesarskich.",
                            Director = "Luc Jacquet",
                            Poster = "cube.jpg",
                            Price = 21.99m,
                            Title = "March of the Penguins"
                        },
                        new
                        {
                            FilmId = 20,
                            CategoryId = 10,
                            Desc = "Miłość i marzenia w świecie muzyki.",
                            Director = "Damien Chazelle",
                            Poster = "cube.jpg",
                            Price = 24.99m,
                            Title = "La La Land"
                        });
                });

            modelBuilder.Entity("ShopUKW2025.Models.Film", b =>
                {
                    b.HasOne("ShopUKW2025.Models.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopUKW2025.Models.Category", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
