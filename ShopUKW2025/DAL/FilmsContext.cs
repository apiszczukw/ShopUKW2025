using Microsoft.EntityFrameworkCore;
using ShopUKW2025.Models;

namespace ShopUKW2025.DAL
{
	public class FilmsContext : DbContext
	{
		public DbSet<Film> Films { get; set; }

		public DbSet<Category> Categories { get; set; }

		public FilmsContext(DbContextOptions options) : base(options)
		{
		}
	}
}
