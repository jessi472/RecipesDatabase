using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesDatabase.Models
{
    public class EFRecipeRepository : IRecipeRepository
    { 
        private RecipesDbContext Context { get; set; }

        public EFRecipeRepository (RecipesDbContext temp)
        {
            Context = temp;
        }
        public IQueryable<Recipe> Recipes => Context.Recipes;
    }
}
