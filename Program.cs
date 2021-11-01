using System;
using System.Linq;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string libraryOption = "";
            do
            {
                string oops = "";
                do 
                {
                    Console.WriteLine("\nBLOGS AND POSTS.  HOW CAN WE HELP YOU?"
                    +"\nA Add a blog to the database"
                    +"\nB List all blogs in database" 
                    +"\nC Add a post to the database"
                    +"\nD List all posts from a blog in database" 
                    +"\nQUIT program");
                    libraryOption = Console.ReadLine().ToUpper();
                    oops = (libraryOption == "A" || libraryOption == "QUIT" ||libraryOption == "B" 
                    || libraryOption == "C" || libraryOption == "D") ? "Y" : "N";
                } while (oops != "Y");  

                //ADD BLOG
                if (libraryOption.ToUpper() == "A")
                {
                    BlogManager blogManager = new BlogManager();
                    blogManager.Add();
                }

                //LIST BLOGS
                else if (libraryOption.ToUpper() == "B")
                {
                    BlogManager blogManager = new BlogManager();
                    blogManager.Display();
                }

                //ADD POSTS
                else if (libraryOption.ToUpper() == "C")
                {
                    PostManager postManager = new PostManager();
                    postManager.Add();
                }

                //LIST BLOGS
                // else if (libraryOption.ToUpper() == "D")
                // {
                //     PostManager postManager = new PostManager();
                //     postManager.Display();
                // }

            } while (!(libraryOption.ToUpper() == "QUIT"));    
        }
    }
}
