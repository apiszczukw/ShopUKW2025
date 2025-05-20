using Microsoft.EntityFrameworkCore;
using ShopUKW2025.Models;

namespace ShopUKW2025.DAL
{
	public class FilmsContext : DbContext
	{
		public DbSet<Film> Films { get; set; }

		public DbSet<Category> Categories { get; set; }

		public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Category> categories = new List<Category>
{
	new Category { CategoryId = 1, Name = "Akcja", Desc = "Filmy pełne dynamicznych scen i emocjonujących pościgów." },
	new Category { CategoryId = 2, Name = "Komedia", Desc = "Filmy, które rozbawią Cię do łez." },
	new Category { CategoryId = 3, Name = "Dramat", Desc = "Opowieści pełne emocji i głębokich przeżyć." },
	new Category { CategoryId = 4, Name = "Science Fiction", Desc = "Filmy o przyszłości, technologii i podróżach kosmicznych." },
	new Category { CategoryId = 5, Name = "Horror", Desc = "Produkcje wywołujące strach i dreszcze." },
	new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy o magicznych światach i niezwykłych stworzeniach." },
	new Category { CategoryId = 7, Name = "Thriller", Desc = "Napięcie i zaskakujące zwroty akcji." },
	new Category { CategoryId = 8, Name = "Animacja", Desc = "Filmy animowane dla dzieci i dorosłych." },
	new Category { CategoryId = 9, Name = "Dokumentalny", Desc = "Filmy oparte na faktach, edukacyjne i inspirujące." },
	new Category { CategoryId = 10, Name = "Romans", Desc = "Historie miłosne pełne wzruszeń i emocji." }
};

			List<Film> films = new List<Film>
{
	new Film { FilmId = 1, Title = "Mad Max: Fury Road", Director = "George Miller", Desc = "Postapokaliptyczna akcja pełna pościgów.", Price = 29.99m, CategoryId = 1, Poster = "plakat1.jpg" },
	new Film { FilmId = 2, Title = "The Hangover", Director = "Todd Phillips", Desc = "Grupa przyjaciół wpada w kłopoty po wieczorze kawalerskim.", Price = 19.99m, CategoryId = 2 , Poster = "plakat2.jpg"},
	new Film { FilmId = 3, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "Historia nadziei i przyjaźni w więzieniu.", Price = 24.99m, CategoryId = 3, Poster = "plakat3.jpg" },
	new Film { FilmId = 4, Title = "Interstellar", Director = "Christopher Nolan", Desc = "Podróż w głąb kosmosu w poszukiwaniu nowego domu dla ludzkości.", Price = 34.99m, CategoryId = 4 , Poster = "plakat4.jpg"},
	new Film { FilmId = 5, Title = "The Conjuring", Director = "James Wan", Desc = "Przerażająca historia nawiedzonego domu.", Price = 22.99m, CategoryId = 5, Poster = "plakat5.jpg" },
	new Film { FilmId = 6, Title = "The Lord of the Rings: The Fellowship of the Ring", Director = "Peter Jackson", Desc = "Początek epickiej podróży w świecie Śródziemia.", Price = 39.99m, CategoryId = 6, Poster = "plakat6.jpg" },
	new Film { FilmId = 7, Title = "Se7en", Director = "David Fincher", Desc = "Detektywi ścigają seryjnego mordercę inspirowanego siedmioma grzechami głównymi.", Price = 27.99m, CategoryId = 7, Poster = "plakat7.jpg" },
	new Film { FilmId = 8, Title = "Toy Story", Director = "John Lasseter", Desc = "Przygody ożywionych zabawek.", Price = 14.99m, CategoryId = 8 , Poster = "plakat8.jpg"},
	new Film { FilmId = 9, Title = "Planet Earth", Director = "Alastair Fothergill", Desc = "Spektakularna podróż przez najpiękniejsze zakątki Ziemi.", Price = 44.99m, CategoryId = 9, Poster = "plakat9.jpg" },
	new Film { FilmId = 10, Title = "The Notebook", Director = "Nick Cassavetes", Desc = "Poruszająca historia miłosna na przestrzeni lat.", Price = 19.99m, CategoryId = 10, Poster = "plakat10.jpg" },
	new Film { FilmId = 11, Title = "John Wick", Director = "Chad Stahelski", Desc = "Zemsta zabójcy na przestępczym świecie.", Price = 32.99m, CategoryId = 1, Poster = "plakat11.jpg" },
	new Film { FilmId = 12, Title = "Superbad", Director = "Greg Mottola", Desc = "Nastoletnie przygody pełne humoru.", Price = 16.99m, CategoryId = 2, Poster = "plakat12.jpg" },
	new Film { FilmId = 13, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "Historia niezwykłego życia Forresta.", Price = 26.99m, CategoryId = 3, Poster = "plakat13.jpg" },
	new Film { FilmId = 14, Title = "Blade Runner 2049", Director = "Denis Villeneuve", Desc = "Kontynuacja kultowego sci-fi.", Price = 37.99m, CategoryId = 4 , Poster = "plakat14.jpg"},
	new Film { FilmId = 15, Title = "It", Director = "Andy Muschietti", Desc = "Mrożący krew w żyłach horror o Pennywise.", Price = 23.99m, CategoryId = 5, Poster = "plakat15.jpg"},
	new Film { FilmId = 16, Title = "Harry Potter and the Sorcerer's Stone", Director = "Chris Columbus", Desc = "Początek magicznej przygody Harry'ego Pottera.", Price = 35.99m, CategoryId = 6, Poster = "cube.jpg"  },
	new Film { FilmId = 17, Title = "Gone Girl", Director = "David Fincher", Desc = "Zniknięcie żony prowadzi do mrocznych tajemnic.", Price = 28.99m, CategoryId = 7, Poster = "cube.jpg" },
	new Film { FilmId = 18, Title = "Shrek", Director = "Andrew Adamson, Vicky Jenson", Desc = "Przygody zielonego ogra.", Price = 18.99m, CategoryId = 8, Poster = "cube.jpg"  },
	new Film { FilmId = 19, Title = "March of the Penguins", Director = "Luc Jacquet", Desc = "Dokument o wędrówce pingwinów cesarskich.", Price = 21.99m, CategoryId = 9 , Poster = "cube.jpg" },
	new Film { FilmId = 20, Title = "La La Land", Director = "Damien Chazelle", Desc = "Miłość i marzenia w świecie muzyki.", Price = 24.99m, CategoryId = 10, Poster = "cube.jpg"  }
};


			modelBuilder.Entity<Category>().HasData(categories);
			modelBuilder.Entity<Film>().HasData(films);

		}
	}
}
