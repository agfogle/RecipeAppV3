using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAppV3.Models
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string RecipeName { get; set; }
        [Required]
        public string RecipeInstructions { get; set; }
    }
}
