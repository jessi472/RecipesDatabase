using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesDatabase.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
    }
}
