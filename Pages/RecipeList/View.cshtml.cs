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
    public class ViewModel : PageModel
    {
        private readonly RecipeDbContext _db;

        public ViewModel(RecipeDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Recipe Recipes { get; set; }

        public async Task OnGet(int ID)
        {
            Recipes = await _db.Recipes.FindAsync(ID);
            /*if (Recipe == null)
            {
                return NotFound();
            }

            //Recipes = await _db.Recipes.FindAsync(ID);
            //Recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.ID == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();*/
        }
    }
}
