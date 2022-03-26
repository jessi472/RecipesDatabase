using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesDatabase.Controllers
{
    public class HomeController : Controller
    {
        
        private IRecipeRepository repo { get; set; }
        public HomeController (IRecipeRepository temp)
        {
            repo = temp;
        }
        

        public IActionResult Index()
        {
            var blah = repo.Recipes
                //.Include(x => RecipeClass) Create Model RecipeClass from RecipeClass Table for this to work.
                //.FromSqlRaw("SELECT * FROM Recipes WHERE RecipeTitle LIKE 'a%'")
                .ToList();

            return View(blah);
        }

        
    }
}
