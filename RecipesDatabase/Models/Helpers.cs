using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Pomelo.EntityFrameworkCore.MySql;

namespace RecipesDatabase.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["RecipesAmazon"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["admin"];
            string password = appConfig["recipes12345"];
            string hostname = appConfig["recipes.c66xpbpanovm.us-east-1.rds.amazonaws.com"];
            string port = appConfig["3306"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}