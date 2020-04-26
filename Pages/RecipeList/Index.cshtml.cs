using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeAppV3.Models;

namespace RecipeAppV3.Pages.RecipeList
{
    public class IndexModel : PageModel
    {
        private readonly RecipeDbContext _db;

        public IndexModel(RecipeDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Recipe> Recipes { get; set; }
        public async Task OnGet()
        {
            Recipes = await _db.Recipes.ToListAsync();

        }
    }
}