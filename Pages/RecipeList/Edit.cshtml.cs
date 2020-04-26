using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeAppV3.Models;

namespace RecipeAppV3.Pages.RecipeList
{
    public class EditModel : PageModel
    {
        private readonly RecipeDbContext _db;

        public EditModel(RecipeDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Recipe Recipes { get; set; }
        public async Task OnGet(int ID)
        {
            Recipes = await _db.Recipes.FindAsync(ID);
        }
    }
}