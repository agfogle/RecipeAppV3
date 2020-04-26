using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeAppV3.Models;

namespace RecipeAppV3.Pages.RecipeList
{
    public class AddModel : PageModel
    {
        private readonly RecipeDbContext _db;

        public AddModel(RecipeDbContext db)
        {
            _db = db;
        }
        
        [BindProperty]
        public Recipe Recipes { get; set; }
        
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Recipes.AddAsync(Recipes);
                await _db.SaveChangesAsync(); //pushes changes to the database
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}