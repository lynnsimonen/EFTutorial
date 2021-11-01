using System;
using System.Collections.Generic;
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
            using (var db = new BlogContext())
            {
                System.Console.WriteLine("Please identify the Blog ID# for the posts that you would like listed: ");  
                int blogID = int.Parse(Console.ReadLine());     
                var listPosts = db.Blogs.Where(x=>x.BlogId == blogID).FirstOrDefault();
            }

            System.Console.WriteLine($"Posts for Blog {Blog.listPosts.Name}");
            Blog blog = new Blog();
            var posts = blog.Posts;
            foreach (var post in blog.Posts) 
            {
                System.Console.WriteLine($"\tPost {post.PostId} {post.Title}");
            }
            
        }
    }
}

//     var blog = db.Blogs.Where(x=>x.BlogId == 1).FirstOrDefault();        //Without the .FirstOrDefault() it HAS NOT executed against list/database YET!
//     //var blogsList = blog.ToList();                                      //NOW the IQuery has been executed against list/database :)