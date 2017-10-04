using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsDemo
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        public virtual List<Post> Posts { get; set; }


    }


    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        
    }


    public class BlogContext: DbContext
    {
        public BlogContext()
        {
            Configuration.LazyLoadingEnabled = false;
            
        }
        public DbSet<Blog> Blogs { get; set; }
    }


    struct C
    {

        public int x, y;
        public const int z = 6;
        Post p;
        public C(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.p = new Post();
        }
    }




    public static class ExtensionHelper
    {
        public static void NewMethod(this Post p)
        {
            Console.WriteLine("This is a new extension method");
        }

    }
}
