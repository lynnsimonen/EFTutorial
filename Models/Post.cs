using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTutorial
{
   public class Post 
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        
        // entity framework relationship
        // Navigation Properties
        public Blog Blog {get;set;}

        // public Post(int PostId, string Title)
        // {
        //     this.PostId = PostId;
        //     this.Title = Title;
        // }
    }

}