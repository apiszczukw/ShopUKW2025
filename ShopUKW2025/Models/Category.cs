using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ShopUKW2025.Models
{
	public class Category
	{
		public int CategoryId { get; set; }

		[Required]
		public string Name { get; set; }

		public string Desc { get; set; }

		public ICollection<Film> Films { get; set; }
	}
}
