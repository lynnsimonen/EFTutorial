using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EFTutorial
{
    public class PostManager
    {       
        public void Add()
        {
            //2. Add Post to database -- ADD POST
            //CRUD - Create, Read, Update, Delete
            System.Console.WriteLine("Enter your Post name");
            var postTitle = Console.ReadLine();

            var post = new Post();
            post.Title = postTitle;


            System.Console.WriteLine("Enter the Blog ID#");
            int blogID = int.Parse(Console.ReadLine());

            var blog = new Blog();
            post.BlogId = blogID;
            //post.BlogId = 1;

            using (var db = new BlogContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        } 
        
        public void Display()
        {
            System.Console.WriteLine("Enter your Blog ID: ");
            var IdBlog = int.Parse(Console.ReadLine());
            using (var db = new BlogContext())
            { 
                var postsReq = db.Posts.Where(x=>x.BlogId == IdBlog);
                var blogPosts = db.Blogs.FirstOrDefault(x=>x.BlogId ==IdBlog);
                System.Console.WriteLine($"\nBlog #{blogPosts.BlogId}: {blogPosts.Name} (includes {postsReq.Count()} posts)");
                string input;
                foreach (var item in postsReq)
                {
                    System.Console.WriteLine($"     Post #{item.PostId}: {item.Title} - {(input = (item.Content != null) ? item.Content : "No Content Yet.")}");
                }                
            }
        }
    }
}