using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFTutorial
{
    public class BlogContext : DbContext
    {
       public DbSet<Blog> Blogs {get; set;}
       public DbSet<Post> Posts {get; set;}
        
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsetting.json")
                .Build();
               
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BloggingContext"));


            

             //kvp = key value pair... libraries
                //dictionary = can look up value of key, kind of like a list
                // Dictionary<string, string> myDictionary = new Dictionary<string, string>();
                // myDictionary.Add("apple", "red");
                // myDictionary.Add("pear", "green");
                // var vlue = myDictionary["apple"];
                //configuration.GetSection("ConnectionStrings")["BloggingContext"];

       } 
    }
}