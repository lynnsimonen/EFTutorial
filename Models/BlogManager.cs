using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTutorial
{
    public class BlogManager
    {
        public void Add()
        {
            Console.WriteLine("Enter your Blog name");
            var blogName = Console.ReadLine();
            var blog = new Blog();
            blog.Name = blogName;

            //using inherits db.Dispose() which is IDisposable automatically when out of scope i.e. "{}"
            using (var db = new BlogContext())     
            {
                db.Add(blog);
                db.SaveChanges();
            }
        }


        public void Display()
        {
            using (var db = new BlogContext())
            {
                System.Console.WriteLine("Here is the list of blogs");
                foreach (var b in db.Blogs) {
                    System.Console.WriteLine($"Blog: {b.BlogId}: {b.Name}");
                }
            }
        }
    }
}