//using System.Data.;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using RecipesDatabase.Models;
using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;

namespace RecipesDatabase.Models
{
    public class RDSContext : DbContext
    {
        public RDSContext(): base(GetRDSConnectionString())
        {
        }

     

        public static RDSContext Create()
        {
            return new RDSContext();
        }
    }
}
