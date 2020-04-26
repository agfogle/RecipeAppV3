using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAppV3.Models
{
    public class RecipeDbContext : DbContext
    {
        //This class allows our program to work with the database. Works with instances of the recipe class. Retrieves and saves Recipes in the database. 
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options): base(options)
        {
                
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
