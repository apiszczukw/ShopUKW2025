using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.DAL;
using ShopUKW2025.Migrations;

namespace ShopUKW2025.ViewComponents
{
	public class MenuViewComponent : ViewComponent
	{
		FilmsContext db;

		public MenuViewComponent(FilmsContext db)
		{
			this.db = db;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = db.Categories.ToList();

			return await Task.FromResult(View("_Menu", categories));
		}
	}
}
