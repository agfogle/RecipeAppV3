using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Recipe")]
        public string RecipeName { get; set; }

        [Required]
        [DisplayName("Ingredients")]
        public string RecipeIngredients { get; set; }

        [Required]
        [DisplayName("Preparation Time")]
        public int RecipeTime { get; set; }

        [Required]
        [DisplayName("Instructions")]
        public string RecipeInstructions { get; set; }
    }
}
